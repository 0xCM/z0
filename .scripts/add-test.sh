Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/test/$ProjectId
ProjectPath=$ProjectDir/$Project

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath
