Project=z0.$ProjectId.$Kind.csproj
ProjectDir=$ZDev/$ProjectId/$Kind
ProjectPath=$ProjectDir/$Project

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath

