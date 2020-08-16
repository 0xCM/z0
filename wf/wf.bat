call wf\wf-vars.cmd

echo off

set Cmd="%Wf%/build.bat"
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