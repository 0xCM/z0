echo off
call wf\wf-vars.cmd
echo on
set Cmd="%Wf%/wf-02-build.bat"
call %Cmd%
