call wf\wf-vars.cmd

echo off

set Cmd="%Wf%/wf-01-needs.bat"
call %Cmd%

set Cmd="%Wf%/wf-02-build.bat"
call %Cmd%

set Cmd="%Wf%/wf-03-ilpack.bat"
call %Cmd%

set Cmd="%Wf%/wf-04-stage.bat"
call %Cmd%

REM call z0.exe

call machine.exe

call zdata.exe

set Cmd="%Wf%/wf-10-respack.bat"
call %Cmd%

set Cmd="wf\wf-deposit.bat"
call %Cmd%

set Cmd="commit.bat"
call %Cmd%

echo on