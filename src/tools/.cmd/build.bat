echo off

set ProjectId=tools
call .cmd\setup.g.cmd

echo %BuildCmd%
call %BuildCmd%

