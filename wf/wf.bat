call wf\wf-vars.cmd

echo off

set Cmd="%Wf%/wf-01-needs.bat"
call %Cmd%

set Cmd="%Wf%/wf-02-build.bat"
call %Cmd%

set Cmd="%Wf%/wf-04-stage.bat"
call %Cmd%

set Cmd="%Wf%/emit.bat"
call %Cmd%

set Cmd="%Wf%/archive.bat"
call %Cmd%

set Cmd="%Wf%/respack.bat"
call %Cmd%

set Cmd="commit.bat"
call %Cmd%

echo on