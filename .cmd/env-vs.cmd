@echo off

set EnvName=vs
set EnvScriptPath=J:\tools\msvs\Common7\Tools\VsDevCmd.bat
echo EnvScriptPath:%EnvScriptPath%

set EnvScriptCmd=cmd /k %EnvScriptPath%
echo EnvScriptCmd:%EnvScriptCmd%

set EnvLogDst=%EnvLogs%\%EnvName%.log
echo EnvLogDst:%EnvLogDst%

call %EnvScriptCmd%

::set > %EnvLogDst%

