AreaDir=$ZDev/src/$AreaId
Project=z0.$ProjectId.csproj
ProjectDir=$AreaDir/$ProjectId
ProjectPath=$ProjectDir/$Project

SlnName=z0.$AreaId.sln
SlnPath=$AreaDir/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath
