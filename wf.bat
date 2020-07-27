echo off
call wf\wf-build.bat
call machine.exe
call zdata.exe
call wf\wf-respack.bat
call wf\wf-deposit.bat
echo on