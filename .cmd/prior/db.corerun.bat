set Db=dumpbin
set DbExe=%Db%.exe
set DbDstRoot=%ZLogs%\tools\%Db%
set DbLogPath=%DbDstRoot%\%Db%.log
set DbDstDir=%DbDstRoot%\runtime

set DbSrcDir=J:\lang\net\runtime\artifacts\bin\coreclr\Windows_NT.x64.Release
set DbSrcFile=CoreRun.exe
set DbSrcPath=%DbSrcDir%\%DbSrcFile%
set DbFlag=disasm
set DbExt=asm
set DbOptions=/%DbFlag%:nobytes
set DbDstFile=%DbSrcFile%.%DbFlag%.%DbExt%
set DbDstPath=%DbDstDir%\%DbDstFile%
set DbCmd=%DbExe% %DbSrcPath% %DbOptions% /out:%DbDstPath%

set Cmd=%DbCmd%
echo %Cmd% >> %DbLogPath%

echo on
call %Cmd%





