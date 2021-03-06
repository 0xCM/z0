@echo off

call %~dp0\env-path-vars.cmd

set SystemPaths=C:\Program Files\PowerShell\7;C:\Windows\system32;C:\Windows;C:\Windows\System32\Wbem;C:\Windows\System32\WindowsPowerShell\v1.0\;C:\Windows\System32\OpenSSH\;C:\Program Files\Microsoft SQL Server\130\Tools\Binn\;C:\Program Files\Microsoft SQL Server\Client SDK\ODBC\170\Tools\Binn\;C:\Program Files\PowerShell\7\;C:\Users\Administrator\AppData\Local\Microsoft\WindowsApps;C:\Users\Administrator\.dotnet\tools
echo SystemPaths:%SystemPaths%

set VarName=PATH
echo VarName:%VarName%

set VarVal=%SystemPaths%;%path_vars%
echo VarVal:%VarVal%
