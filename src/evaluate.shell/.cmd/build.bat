echo off

set ProjectId=evaluate.shell

call .cmd\setup.g.cmd
call %BuildCmd%

z0 dynamic evaluate