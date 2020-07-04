SlnRoot=$ZDev/src/$SlnId
SlnName=z0.$SlnId.sln
SlnPath=$SlnRoot/$SlnName

Project=z0.$ProjectId.csproj
ProjectDir=$SlnRoot/$ProjectId
ProjectPath=$ProjectDir/$Project

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath