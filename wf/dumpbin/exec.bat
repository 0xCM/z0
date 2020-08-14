echo off

set WfRoot=%ZDev%\wf
call %WfRoot%\wf-vars.cmd

set Tool=dumpbin
set Step=%WfRoot%\%Tool%

call %WfRoot%\%Tool%\clean.bat

set SrcDir=%ZDev%\bin\lib\netcoreapp3.0

set SrcFile=z0.sys.dll
set Cmd=%Step%\dump.dll.clr.bat
call %Cmd%

set SrcFile=zdata.dll
set Cmd=%Step%\dump.dll.clr.bat
call %Cmd%

set SrcFile=zdata.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=machine.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=machine.dll
set Cmd=%Step%\dump.dll.clr.bat
call %Cmd%

set SrcFile=z0.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=zrun.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=ztool.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=ztool.dll
set Cmd=%Step%\dump.dll.clr.bat
call %Cmd%

REM set SrcFile=z0.win.dll
REM set Cmd=%Step%\dump.dll.clr.bat
REM call %Cmd%

REM set SrcFile=osextensions.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=dia2lib.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=z0-vml-clib.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcDir=%LibDir%

REM set SrcFile=kernel32.lib
REM set Cmd=%Step%\dump.lib.bat
REM call %Cmd%

REM set SrcDir=%ToolDir%

REM set SrcFile=clrjit.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=coreclr.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=cppwinrt.exe
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-heap-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-math-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-stdio-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-string-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-locale-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-filesystem-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-convert-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-time-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=ucrtbase.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-core-file-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-core-memory-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=cpfecl.Clang.Windows.x64.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=CodeMarkersEtwRc.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=clrcompression.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-eventing-provider-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-crt-utility-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=API-MS-Win-core-xstate-l2-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-core-processenvironment-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=api-ms-win-core-processthreads-l1-1-0.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%

REM set SrcFile=mscordaccore.dll
REM set Cmd=%Step%\dump.dll.native.bat
REM call %Cmd%


