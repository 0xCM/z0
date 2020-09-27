echo off
set ProjectId=derivatives
call %ZDev%\src\%ProjectId%\vars.cmd
call %BuildCmd%
z0 %ProjectId%.runner