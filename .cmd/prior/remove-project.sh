Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/$ProjectId/src
ProjectPath=$ProjectDir/$Project

Test=z0.$ProjectId.test.csproj
TestDir=$ZDev/$ProjectId/test
TestPath=$TestDir/$Test

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Removing $Project from $SlnName solution
dotnet sln $SlnPath remove $ProjectPath

echo Removing $Test from $SlnName solution
dotnet sln $SlnPath remove $TestPath
