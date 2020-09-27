echo off
set ProjectId=bitfields
call %ZDev%\src\%ProjectId%\vars.cmd
call %BuildCmd%
z0 %ProjectId%.run