echo off

set WfRoot=%ZDev%\wf
set Step=%WfRoot%\%Tool%
set SrcPath=%SrcDir%\%SrcFile%

set Flag=%Summary%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%ClrHeader%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Headers%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%LoadConfig%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%RawData%
set CmdOptions=%Hex8x32%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag%:%CmdOptions% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Summary%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Disasm%
set DstFile=%SrcFile%.asm
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Disasm%
set DstFile=%SrcFile%.%Flag%.instructions.asm
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag%:nobytes /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Exports%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Fpo%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Headers%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%Imports%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%

set Flag=%RawData%
set CmdOptions=%Hex8x32%
set DstFile=%SrcFile%.%Flag%.doc
set DstPath=%DstDir%\%DstFile%
set Cmd=%Tool% %DefaultFlags% /%Flag%:%CmdOptions% /out:%DstPath% %SrcPath%
echo %Cmd% >> %LogPath%
echo %Cmd%
call %Cmd%