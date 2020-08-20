set Cg=crossgen

set Artifacts=j:\lang\net\runtime\artifacts
set ClrRoot=J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root
set CgSrcDir=J:\dev\projects\z0\bin\lib\netcoreapp5.0\win-x64
set CgDstDir=%ZLogs%\builds\%Cg%

set CgExe=%ClrRoot%\%Cg%.exe
set CgLogDir=%ZLogs%\tools\%Cg%
set CgLogPath=%CgLogDir%\%Cg%.log

set CgOptions=/verbose /ReadyToRun
set CgSrcFile=Machine.dll
set CgDstFile=Machine.dll
set CgSrcPath=%CgSrcDir%\%CgSrcFile%
set CgDstFile=%CgSrcName%.%CgDstExt%
set CgDstPath=%CgDstDir%\%CgDstFile%
set CgSrcSpec=/in %CgSrcPath%
set CgDstSpec=/out %CgDstPath%
set CgCmd=%CgExe% %CgOptions% %CgSrcSpec% %CgDstSpec%

set Cmd=%CgCmd%
echo %Cmd% >> %CgLogPath%

echo on
call %Cmd%