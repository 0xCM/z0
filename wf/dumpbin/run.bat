set WfRoot=%ZDev%\wf
call %WfRoot%\wf-vars.cmd

set Tool=dumpbin
set Step=%WfRoot%\%Tool%

call %Step%\clean.bat

set SrcDir=%ZDev%\bin\lib\netcoreapp3.0

set SrcFile=z0.sys.dll
set Cmd=%Step%\dump.dll.clr.bat
call %Cmd%

set SrcFile=zdata.dll
set Cmd=%Step%\dump.dll.clr.bat
call %Cmd%

set SrcFile=machine.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=z0.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=zdata.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=z0.metareader.exe
set Cmd=%Step%\dump.exe.bat
call %Cmd%

set SrcFile=osextensions.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=dia2lib.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcDir=%LibDir%

set SrcFile=kernel32.lib
set Cmd=%Step%\dump.lib.bat
call %Cmd%

set SrcDir=%ToolDir%

set SrcFile=clrjit.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=coreclr.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=cppwinrt.exe
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-heap-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-math-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-stdio-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-string-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-locale-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-filesystem-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-convert-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=api-ms-win-crt-time-l1-1-0.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%

set SrcFile=ucrtbased.dll
set Cmd=%Step%\dump.dll.native.bat
call %Cmd%
