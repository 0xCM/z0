echo off

set DstRoot=%ZLogs%\tools
set Artifacts=j:\lang\net\runtime\artifacts
set ClrRoot=J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root

set Cg=crossgen
set CgExe=%ClrRoot%\%Cg%.exe
set CgLogPath=%CgDstRoot%\%Cg%.log
set CgDstRoot=%DstRoot%\%Cg%
set CgDstDir=%CgDstRoot%\runtime

set CgOptions=/verbose /ReadyToRun
set CgSrcExt=dll
set CgDstExt=ReadyToRun.ni.%CgSrcExt%
set CgSrcName=System.Private.CoreLib
set CgSrcDir=%ClrRoot%\IL
set CgSrcFile=%CgSrcName%.%CgSrcExt%
set CgSrcPath=%CgSrcDir%\%CgSrcFile%

set CgDstFile=%CgSrcName%.%CgDstExt%
set CgDstPath=%CgDstDir%\%CgDstFile%

set CgSrcSpec=/in %CgSrcPath%
set CgDstSpec=/out %CgDstPath%
set CgCmd=%CgExe% %CgOptions% %CgSrcSpec% %CgDstSpec%

echo %CgCmd% >> %CgLogPath%

REM echo on
REM call %CgCmd% >> %CgLogPath%
REM echo off

set Db=dumpbin
set DbExe=%Db%.exe
set DbDstRoot=%DstRoot%\%Db%
set DbLogPath=%DbDstRoot%\%Db%.log
set DbDstDir=%DbDstRoot%\runtime
set DbFlag=disasm
set DbOptions=/%DbFlag%:nobytes
set DbDstExt=asm
set DbSrcDir=%CgDstDir%
set DbSrcFile=%CgDstFile%
set DbSrcPath=%CgDstPath%
set DbDstFile=%DbSrcFile%.%DbFlag%.%DbDstExt%
set DbDstPath=%DbDstDir%\%DbDstFile%

set DbCmd=%DbExe% %DbSrcPath% %DbOptions% /out:%DbDstPath%

echo %DbCmd% > %DbLogPath%

echo on
call %DbCmd% >> %DbLogPath%
