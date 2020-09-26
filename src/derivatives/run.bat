echo off
set ProjectId=derivatives
call %ZDev%\src\%ProjectId%\vars.cmd
echo %RunCmd%
call %RunCmd%