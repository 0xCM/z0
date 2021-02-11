source $(dirname $0)/vars.sh

Project=z0.$ProjectId.csproj
ProjectDir=$DevRoot/src/$ProjectId
ProjectPath=$ProjectDir/$Project
SlnPath=$DevRoot/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath
