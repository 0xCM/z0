echo off

set ProjectId=tools
set ExeName=ztool

call .cmd\setup.g.cmd

echo Executing %BuildCmd%
call %BuildCmd%

call %ExeName%
