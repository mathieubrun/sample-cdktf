import { Construct } from "constructs";
import { Integer, Password, RandomProvider } from "./.gen/providers/random"
import { TerraformStack } from "cdktf";

export class RandomTerraformStack extends TerraformStack {
  constructor(scope: Construct, name: string) {
    super(scope, 
      name);

    new RandomProvider(this, "random");

    var len = new Integer(this, "integer", {
      min: 0,
      max: 10
    });

    new Password(this, "password", {
      length: len.result
    });
  }
}
