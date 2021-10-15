using System;
using HashiCorp.Cdktf;

namespace Sample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            App app = new App();
            new RandomTerraformStack(app, "terraform-cdk-random");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}