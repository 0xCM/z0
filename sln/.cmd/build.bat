echo off

set ProjectId=sln
echo ProjectId:%SlnId%

set ProjectPath="%ZDev%\%ProjectId%"
echo ProjectPath:%ProjectPath%

set BuildLogPath="%ZDb%\logs\build\%ProjectId%.log"

set BuildCmd=dotnet build %SlnPath% /p:Configuration=Release /p:Platform="Any CPU" -fl -flp:logfile=%BuildLogPath%;verbosity=detailed -m:6 -graph:true
echo BuildCmd:%BuildCmd%

echo on
call %BuildCmd%
