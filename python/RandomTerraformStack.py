#!/usr/bin/env python
from os import environ

from cdktf import TerraformStack
from constructs import Construct

from imports.random import Integer, Password, RandomProvider

class RandomTerraformStack(TerraformStack):
    def __init__(self, scope: Construct, ns: str):
        super().__init__(scope, ns)

        RandomProvider(self, 'random')
    
        length = Integer(self, "length", min=5, max=10)
        
        Password(self, f"password",
          length=length.result
        )
