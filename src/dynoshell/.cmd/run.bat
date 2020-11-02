echo off

set ProjectId=evaluate.shell

call .cmd\setup.g.cmd

echo Executing %RunCmd%
call %RunCmd%
