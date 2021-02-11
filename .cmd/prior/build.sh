source $(dirname $0)/vars.sh

Project=z0.$ProjectId.csproj
ProjectDir=$DevRoot/src/$ProjectId
ProjectPath=$ProjectDir/$Project

cd $ProjectDir
echo building $Project
dotnet build

