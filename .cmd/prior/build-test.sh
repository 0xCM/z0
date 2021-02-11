Project=z0.$ProjectId.test
ProjectLoc=$ProjectId/test
ProjectDir=$ZDev/$ProjectLoc

cd $ProjectDir
echo building $Project
dotnet build