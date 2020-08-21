echo off

set Tool=dumpbin

set WfRoot=%ZDev%\wf
call %WfRoot%\wf-vars.cmd
call %WfRoot%\%Tool%\config.cmd

set LogPath=%ToolLogPath%
set DstDir=%ToolDstDir%\z0

rmdir %DstDir% /q /s
mkdir %DstDir%

set SrcDir=%DevBuild%
set CmdFile=dump.all.bat
set Step=%WfRoot%\%Tool%

set SrcFile=z0.sys.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=zdata.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=zdata.exe
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=machine.exe
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=machine.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=z0.exe
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=zrun.exe
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=ztool.exe
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=ztool.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=z0.win.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set DstDir=%ToolDstDir%\external
rmdir %DstDir% /q /s
mkdir %DstDir%

set SrcFile=dia2lib.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=z0-vml-clib.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=kernel32.lib
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=clrjit.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=coreclr.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=cppwinrt.exe
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-heap-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-math-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-stdio-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-string-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-locale-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-filesystem-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-convert-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-time-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=ucrtbase.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-core-file-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-core-memory-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=cpfecl.Clang.Windows.x64.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=CodeMarkersEtwRc.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=clrcompression.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-eventing-provider-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-crt-utility-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=API-MS-Win-core-xstate-l2-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-core-processenvironment-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=api-ms-win-core-processthreads-l1-1-0.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%

set SrcFile=mscordaccore.dll
set Cmd=%Step%\%CmdFile%
call %Cmd%