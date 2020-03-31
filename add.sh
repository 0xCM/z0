ProjectId=nats
ProjectDir=$ZDev/test/$ProjectId
ProjectName=z0.$ProjectId.test.csproj
ProjectPath=$ProjectDir/$ProjectName

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath

