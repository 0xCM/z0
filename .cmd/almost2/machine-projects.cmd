echo off

call .cmd\setup.cmd
set SlnAppId=machine
set SlnId=machine

set SlnVarsCmd=.cmd\sln-set-vars.cmd
echo SlnVarsCmd:%SlnVarsCmd%

call %SlnVarsCmd%

set SlnListCmd=dotnet sln %SlnPath% list
echo SlnListCmd:%SlnListCmd%

call %SlnListCmd% > .logs\%SlnId%.projects.list