echo off
set WfRoot=%ZDev%\wf
set Tool=dumpbin
set Step=%WfRoot%\%Tool%

call %WfRoot%\wf-vars.cmd
call %Step%\tool.cmd

set SrcPath=%SrcDir%\%SrcFile%
set DstDir=%ZLogs%\tools\%Tool%
set LogPath=%ZLogs%\tools\logs\%Tool%.log

set Flag=%Summary%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%ClrHeader%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%Headers%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%LoadConfig%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%RawData%
set CmdOptions=%Hex8x32%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag%:%CmdOptions% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

echo on