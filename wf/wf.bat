call wf\wf-vars.cmd

echo off

set Cmd="%Wf%/wf-01-needs.bat"
call %Cmd%

set Cmd="%Wf%/wf-02-build.bat"
call %Cmd%

set Cmd="%Wf%/wf-04-stage.bat"
call %Cmd%

z0 > %ZLogs%\etl\control.csv 

machine > %ZLogs%\etl\machine.csv

set Cmd="wf\wf-05-archive.bat"
call %Cmd%

set Cmd="%Wf%/wf-10-respack.bat"
call %Cmd%

set Cmd="commit.bat"
call %Cmd%

echo on