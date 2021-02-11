
set SrcName=System.ni.dll
set SrcPath=%SrcPath%

set DbFlag=disasm
set DstExt=asm
set DbOptions=/%DbFlag%:nobytes

set DbDstFile=%DbSrcFile%.%DbFlag%.%DbExt%
set DbDstPath=%DbDstDir%\%DbDstFile%
set DbCmd=%DbTool% %DbSrcPath% %DbFlags% /out:%DbDstPath%

echo on

call %DbCmd%

