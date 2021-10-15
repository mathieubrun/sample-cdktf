using System;
using Constructs;
using HashiCorp.Cdktf;
using random;

namespace Sample
{
    class RandomTerraformStack : TerraformStack
    {
        public RandomTerraformStack(Construct scope, string id) : base(scope, id)
        {
            // define resources here
            new RandomProvider(this, "random-csharp");

            var length = new Integer(this, "length", new IntegerConfig(){
                Min = 5,
                Max = 10
            });

            var password = new Password(this, "password", new PasswordConfig()
            {
                Length = length.Result
            });
        }
    }
}