SrcRootLoc=$ParentId/$SrcRootName/$SrcId
SrcRootDir=$ZDev/$SrcRootLoc

SrcProjectId=$ParentId.$SrcId
SrcProjectName=z0.$SrcProjectId.csproj

SrcProjectPath=$SrcRootDir/$SrcProjectName

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Adding $SrcProjectName to $SlnName solution
dotnet sln $SlnPath add $SrcProjectPath
