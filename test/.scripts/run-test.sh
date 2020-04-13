Project=z0.$ProjectId.test
ProjectDir=$ZDev/test/$ProjectId
ExeName=$Project.exe
ExePath=$ZDev/bin/obj/$Project/netcoreapp3.0/$ExeName

LogExt=log
LogDir=$ZLogs/test
LogSrc=console
LogName=$Project.$LogSrc.$LogExt
cd $ProjectDir
echo Executing tests defined by $Project

dotnet run 

