Project=z0.$ProjectId.test
ProjectLoc=$ProjectId/test
ProjectDir=$ZDev/$ProjectLoc
LogExt=log
LogDir=$ZLogs/test
LogSrc=console
LogName=$Project.$LogSrc.$LogExt
cd $ProjectDir
echo $Project
dotnet run > $LogDir/$LogName