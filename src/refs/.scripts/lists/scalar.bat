echo off
set SetVarsCmd=%ZDev%\src\tool.docs\vars.cmd

call %SetVarsCmd%

set ToolSrc=J:\tools\scalar\git
set SearchPattern=*.exe
set CaptureFile=scalar.md
set CmdName=dir
set CmdOptions=/b /s
set CmdInput=%ToolSrc%\%SearchPattern%
set Cmd=%CmdName% %CmdInput% %CmdOptions%
set CmdOutput=%CaptureDir%\%CaptureFile%

set CmdHeader=# Command %CmdName% %ToolSrc%
set CmdInfo=## CmdName={%CmdName%} CmdOptions={%CmdOptions%} CmdInput={%CmdInput%} CmdOutput={%CapturePath%}
set CmdText=## Cmd={%Cmd%}

echo %CmdHeader% > %CmdOutput%
echo %CmdInfo% >> %CmdOutput%
echo %CmdText% >> %CmdOutput%
echo %PageBreak% >> %CmdOutput%

call %Cmd% >> %CmdOutput%

