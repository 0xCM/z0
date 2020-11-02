echo off

set ProjectId=dynoshell

call .cmd\setup.g.cmd
echo %BuildCmd%
call %BuildCmd%

z0 domain dynamic evaluate