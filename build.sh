#!/bin/sh

set -e
set -x

export PATH=~/.dotnet:~/go/bin:$PATH
export DOTNET_ROOT=~/.dotnet

mkdir build
mkdir build/Types
mkdir build/Client
mkdir build/Server

git clone https://github.com/harmony-development/harmony-dotnet-sdk repo
git clone https://github.com/harmony-development/protocol

cp repo/builder.csproj protocol
cp repo/buf.gen.yaml protocol

cd protocol
buf generate
mv gen ..
dotnet build
cd

cp -r protocol/obj/Debug/net6.0/* build/Types
rm build/Types/* || true # delete all top-level files but leave anything in folders

cp -r gen/client/* build/Client
cp -r gen/server/* build/Server

cp repo/harmony-dotnet-sdk.csproj build
cd build

find . -name "*Grpc.cs" -delete
find . -type f -exec sed -i "s/namespace Protocol/namespace Harmony/" {} \;
find . -type f -exec sed -i "s/global::Protocol/global::Harmony/g" {} \;

~/.dotnet/tools/dotnet-format
dotnet build
