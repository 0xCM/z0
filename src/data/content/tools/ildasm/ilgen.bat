echo off

set ToolPath=J:\lang\net\runtime\artifacts\toolset\ilasm\ildasm.exe
set SrcRoot=j:\dev\projects\z0
set SrcDir=%SrcRoot%\bin\lib\netcoreapp3.0
set DstRoot=j:\dev\projects\z0-logs

set SrcName=z0.math.dll
set Tool=ildasm
set MdOptionName=heaps
set MdOptions=-METADATA=%MdOptionName%
set DefaultOptions=-bytes -raweh -tokens -linenum -forward -typelist -headers -stats -classlist
set Options=%DefaultOptions% %MdOptions%
set DstExt=%MdOptionName%.il

set DstDir=%DstRoot%\tools\%Tool%
set LogPath=%DstDir%\%Tool%.log

set Cmd=del %DstDir%\%SrcName% /Q
echo %Cmd% >> %LogPath%

echo on
call %Cmd%
echo off

set DstName=%SrcName%.%DstExt%
set SrcPath="%SrcDir%\%SrcName%"
set DstPath=%DstDir%\%DstName%
set DstSpec=-OUT="%DstPath%"

set Cmd=%ToolPath% %Options% %SrcPath% %DstSpec%

echo %Cmd%
echo %Cmd% >> %LogPath%
call %Cmd%

set Cmd=del %DstDir%\*.res /Q
call %Cmd%

:: set UsagePath=%SrcRoot%\src\tools\specs\%Tool%.doc
:: set Cmd=%ToolPath% > %UsagePath%
:: echo %Cmd% >> %LogPath%
:: call %Cmd% > %UsagePath%