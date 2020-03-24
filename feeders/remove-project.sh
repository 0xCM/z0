Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/$ProjectRoot/$ProjectId
ProjectPath=$ProjectDir/$Project

SlnName=z0.sln
SlnPath=$ZDev/$SlnName

echo Removing $Project from $SlnName solution
dotnet sln $SlnPath remove $ProjectPath


# Project=z0.feeders.$ProjectId.csproj
# ProjectDir=$ZDev/$ProjectRoot/$ProjectId
# ProjectPath=$ProjectDir/$Project

# SlnName=z0.sln
# SlnPath=$ZDev/$SlnName

# echo Removing $Project from $SlnName solution
# dotnet sln $SlnPath remove $ProjectPath
