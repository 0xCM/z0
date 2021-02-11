set Db=dumpbin
set DbExe=%Db%.exe
set DbDstRoot=%ZLogs%\tools\%Db%
set DbLogPath=%DbDstRoot%\%Db%.log
set DbDstDir=%DbDstRoot%\runtime

set DbSrcDir=J:\lang\net\runtime\artifacts\bin\coreclr\Windows_NT.x64.Debug\lib
set DbSrcFile=coreclr_static.lib
set DbSrcPath=%DbSrcDir%\%DbSrcFile%
set DbFlag=disasm
set DbExt=asm
set DbOptions=/%DbFlag%
set DbDstFile=%DbSrcFile%.%DbFlag%.%DbExt%
set DbDstPath=%DbDstDir%\%DbDstFile%
set DbCmd=%DbExe% %DbSrcPath% %DbOptions% /out:%DbDstPath%


set Cmd=%DbCmd%
echo %Cmd% >> %DbLogPath%

echo on
call %Cmd%

echo off

set DbFlag=archivemembers
set DbExt=%DbFlag%.doc
set DbOptions=/%DbFlag%
set DbDstFile=%DbSrcFile%.%DbExt%
set DbDstPath=%DbDstDir%\%DbDstFile%
set DbCmd=%DbExe% %DbSrcPath% %DbOptions% /out:%DbDstPath%

REM set Cmd=%DbCmd%
REM echo %Cmd% >> %DbLogPath%
REM echo on
REM call %Cmd%

