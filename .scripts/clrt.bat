echo off

set core_root=J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug\Tests\Core_Root
set test_root=J:\lang\net\runtime\artifacts\tests\coreclr\Windows_NT.x64.Debug
set CoreRun=%core_root%\corerun.exe
set RunCrossGen=1
set jit_test=%test_root%\JIT

set JtM=%jit_test%\Methodical
set jit_uint64=%JtM%\int64\unsigned
set jit_uint64_reladdsub_cmd=%jit_uint64%\_reladdsub\_reladdsub.cmd
set Cmd=%jit_uint64_reladdsub_cmd%

set Cg=%jit_test%\CodeGenBringUpTests

set Cg_001=ArrayExc

set Cg_001ro_name=%Cg_001%_ro
set Cg_001ro_root=%Cg%\%Cg_001ro_name%\%Cg_001ro_name%
set Cg_001ro_cmd=%Cg_001ro_root%.cmd
set Cg_001ro_dll=%Cg_001ro_root%.dll

set Cmd=%Cg_001ro_cmd%

set Db=dumpbin
set DbExe=%Db%.exe
set DbDstRoot=%ZLogs%\tools\%Db%
set DbLogPath=%DbDstRoot%\%Db%.log
set DbDstDir=%DbDstRoot%\runtime
set DbSrcFile=%Cg_001ro_name%.dll
set DbSrcPath=%Cg_001ro_dll%
set DbFlag=all
set DbExt=doc
set DbOptions=/all
set DbDstFile=%DbSrcFile%.%DbFlag%.%DbExt%
set DbDstPath=%DbDstDir%\%DbDstFile%
set DbCmd=%DbExe% %DbSrcPath% %DbOptions% /out:%DbDstPath%

set Cmd=%DbCmd%
echo %Cmd% >> %DbLogPath%

echo on
call %Cmd%





