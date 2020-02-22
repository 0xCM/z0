Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/$ProjectId/src
ProjectPath=$ProjectDir/$Project

Test=z0.$ProjectId.test.csproj
TestDir=$ZDev/$ProjectId/test
TestPath=$TestDir/$Test

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath

echo Adding $Test to $SlnName solution
dotnet sln $SlnPath add $TestPath
