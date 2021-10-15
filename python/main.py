#!/usr/bin/env python
from cdktf import App
from RandomTerraformStack import RandomTerraformStack

app = App()

RandomTerraformStack(app, "random")

app.synth()
