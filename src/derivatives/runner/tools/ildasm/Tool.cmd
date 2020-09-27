echo off

set Tool=ildasm
set ToolPath=J:\lang\net\runtime\artifacts\toolset\ilasm\ildasm.exe
set SrcRoot=j:\dev\projects\z0
set BuildDir=%SrcRoot%\.build\bin\netcoreapp3.1
set DstDir=j:\dev\projects\z0-logs\tools\ildasm
set LogPath=%DstDir%\%Tool%.log

set SrcName=z0.dvec.dll
set MdOptionName=raw
set SrcPath=%BuildDir%\%SrcName%
set MdOptions=-METADATA=%MdOptionName%
set Flags=-bytes -raweh -tokens -linenum -forward -typelist -headers -stats -classlist
set Options=%Flags% %MdOptions%
set DstExt=%MdOptionName%.il
set DstName=%SrcName%.%DstExt%
set DstPath=%DstDir%\%DstName%
set DstSpec=-OUT="%DstPath%"

set Cmd=%ToolPath% %Options% %SrcPath% %DstSpec%

:: set Cmd=del %DstDir%\%SrcName% /Q
:: echo %Cmd% >> %LogPath%
:: echo on
:: call %Cmd%
:: echo off

echo %Cmd%
echo %Cmd% >> %LogPath%
call %Cmd%

set Cmd=del %DstDir%\*.res /Q
call %Cmd%
