# Terraform CDK sample 

See announcement here : https://www.hashicorp.com/blog/cdk-for-terraform-0-6-adds-unit-testing
Documentation here : https://github.com/hashicorp/terraform-cdk#documentation
Tutorial here : https://learn.hashicorp.com/tutorials/terraform/cdktf-install

## Getting started

- Open the folder with the language of your choice in VSCode
- for this example, I'll choose typescript, as it is the most advanced one : it has tests !
- choose "Reopen in container" when prompted : this will restart vscode with a dev container, with all dependencies (npm, typescript, cdktf, terraform )
- wait for the devcontainer to build. Have a look at the log if you're curious !
- open vscode integrated terminal (which'll run in the devcontainer)
- run `npm install` to download npm dependencies
- run `cdktf get` to transform required terraform providers (here only random is used) into typescript code

## Playing around
- `cdktf synth` will create a terraform json file that can be used by `terraform plan/apply`
- `cdktf diff` which is equivalent as `terraform plan`
- `cdktf diff` which is equivalent as `terraform plan`
- `cdktf deploy` which is equivalent as `terraform apply`
- change the code in random-terraform-stack.txt
- see if tests (in __tests__ folder) break