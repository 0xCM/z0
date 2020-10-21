echo off

set ProjectId=tools

call .cmd\setup.g.cmd

echo Executing %RunCmd%
call %RunCmd%
