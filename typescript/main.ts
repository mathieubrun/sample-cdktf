import { App } from "cdktf";
import { RandomTerraformStack } from "./random-terraform-stack";

const app = new App();
new RandomTerraformStack(app, "typescript");
app.synth();
