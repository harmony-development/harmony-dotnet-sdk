#!/bin/bash

buf generate git://github.com/harmony-development/protocol.git#branch=${1:-main}
dotnet build -c Release
dotnet pack -c Release