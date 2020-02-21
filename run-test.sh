Project=z0.$ProjectId.test
ProjectLoc=$ProjectId/test
ProjectDir=$ZDev/$ProjectLoc
LogDir=$ZLogs/test
LogName=$Project.log
cd $ProjectDir
echo $Project
dotnet run > $LogDir/$LogName