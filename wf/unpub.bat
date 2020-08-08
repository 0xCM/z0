set SrcDir=J:\dev\projects\z0\bin\pub
set DstDir=J:\dev\projects\z0\bin\pub_dumpbin
set Tool=dumpbin.exe

set Cmd=%Tool% /disasm:nobytes /out:%DstDir%\z0.gvec.test.exe.nobytes.asm %SrcDir%\z0.gvec.test.exe
call %Cmd%

set Cmd=%Tool% /disasm:nobytes /out:%DstDir%\z0.fixed.dll.nobytes.asm %SrcDir%\z0.fixed.dll
call %Cmd%

set Cmd=%Tool% /rawdata:1,32 /out:%DstDir%\z0.fixed.dll.raw %SrcDir%\z0.fixed.dll
call %Cmd%
