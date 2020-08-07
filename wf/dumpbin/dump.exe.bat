echo off
set WfRoot=%ZDev%\wf
set Tool=dumpbin
set Step=%WfRoot%\%Tool%

call %WfRoot%\wf-vars.cmd
call %Step%\tool.cmd

set SrcPath=%SrcDir%\%SrcFile%
set DstDir=%StageBuild%\%Tool%
set LogPath=%StageBuild%\%Tool%.log

set Flag=%Summary%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%ArchiveMembers%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% > %LogPath%
call %Cmd%

set Flag=%ClrHeader%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%Dependents%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%Disasm%
set DstFile=%SrcFile%.%Flag%.asm
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

set Flag=%Imports%
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

set Flag=%Relocations%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

set Flag=%Tls%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%Flag%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
call %Cmd%

echo on