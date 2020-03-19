Project=z0.$ProjectId.app
ProjectLoc=$ProjectId/app
ProjectDir=$ZDev/$ProjectLoc

ExeName=$Project.exe
ExePath=$ZDev/bin/obj/$Project/netcoreapp3.0/$ExeName

LogExt=log
LogDir=$ZLogs/app
LogSrc=console
LogName=$Project.$LogSrc.$LogExt
cd $ProjectDir
echo running application $Project

dotnet run 
#> $LogDir/$LogName
