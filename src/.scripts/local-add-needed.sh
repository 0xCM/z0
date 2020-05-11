ProjectDir=$ZDev/src/$ProjectId
SlnName=z0.$ProjectId.sln
SlnPath=$ProjectDir/$SlnName

NeededProj=z0.$NeededId.csproj
NeededDir=$ZDev/src/$NeededId
NeededPath=$NeededDir/$NeededProj

echo Adding $NeededPath to $SlnPath solution
dotnet sln $SlnPath add $NeededPath
