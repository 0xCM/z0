SrcRoot=$ZDev/src
AreaDir=$SrcRoot/$AreaId
NeedProj=z0.$ProjectId.csproj
NeedDir=$SrcRoot/$ProjectId
NeedPath=$NeedDir/$NeedProj

SlnName=z0.$AreaId.sln
SlnPath=$AreaDir/$SlnName

echo Adding $NeedProj to $SlnName solution
dotnet sln $SlnPath add $NeedPath
