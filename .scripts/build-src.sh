Project=z0.$ProjectId
ProjectLoc=$ProjectId/src
ProjectDir=$ZDev/$ProjectLoc

cd $ProjectDir
echo building $Project
dotnet build