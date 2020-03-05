Project=z0.$ProjectId
ProjectLoc=$ProjectId/src
ProjectDir=$ZDev/$ProjectLoc

cd $ProjectDir
echo building $Project
dotnet build -bl:$ZDev/bin/z0.$ProjectId.binlog

