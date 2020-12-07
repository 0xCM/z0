echo off

set EnvName=vcvars64
set VsDir=J:\tools\msvs\VC\Auxiliary\Build

set EnvScriptFile=%EnvName%.bat
echo EnvScriptFile:%EnvScriptFile%

set EnvScriptPath="%VsDir%\%EnvScriptFile%"
echo EnvScriptPath:%EnvScriptPath%

set EnvScriptCmd=cmd /k %EnvScriptPath%
echo EnvScriptCmd:%EnvScriptCmd%

set EnvLogDst=%EnvLogs%\%EnvName%.log
echo EnvLogDst:%EnvLogDst%

call %EnvScriptCmd%

set > %EnvLogDst%