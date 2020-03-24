Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/$ProjectId/src
ProjectPath=$ProjectDir/$Project

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Removing $Project from $SlnName solution
dotnet sln $SlnPath remove $ProjectPath
