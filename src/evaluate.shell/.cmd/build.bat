echo off

set ProjectId=evaluate.shell

call .cmd\setup.g.cmd
echo %BuildCmd%
call %BuildCmd%

: z0 domain dynamic evaluate