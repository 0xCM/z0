Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/src/$ProjectId
ProjectPath=$ProjectDir/$Project

SlnDir=$ProjectDir

SlnName=z0.$ProjectId.sln
SlnPath=$SlnDir/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath
