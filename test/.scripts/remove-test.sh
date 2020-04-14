TestRoot=$ZDev/test
Project=z0.$ProjectId.test.csproj
ProjectDir=$TestRoot/$ProjectId
ProjectPath=$ProjectDir/$Project

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Removing $Project from $SlnName solution
dotnet sln $SlnPath remove $ProjectPath
