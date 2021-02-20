Project=z0.$ProjectId.run.csproj
ProjectDir=$ZDev/src/$ProjectId
ProjectPath=$ProjectDir/$Project

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath
