echo off
call wf\wf-vars.cmd
echo on
set Cmd="%Wf%/wf-04-stage.bat"
call %Cmd%
