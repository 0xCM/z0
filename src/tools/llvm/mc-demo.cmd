echo off

set ToolName=llvm-mc
set ToolAction=disassemble

set ToolSrcName=sys.alloc.u8
set ToolSrcName=sys.proxy.alloc.u8
set ToolSrcName=run.fx.slots.exec1

set ToolSrcFile=%ToolSrcName%.hex
set ToolSrcPath=demos\%ToolName%\sources\%ToolSrcFile%

set ToolDstFile=%ToolSrcName%.asm
set ToolDstPath=demos\%ToolName%\targets\%ToolDstFile%

set AsmSyntaxOption=x86-asm-syntax=intel

set ToolOptions= --%AsmSyntaxOption% --show-inst-operands --show-encoding --asm-show-inst --print-imm-hex --masm-integers --triple=x86_64-pc-windows-msvc --filetype=asm -o=%ToolDstPath%
set ToolCmd=%ToolName% --%ToolAction% %ToolOptions% %ToolSrcPath%

echo ToolCmd:%ToolCmd%
call %ToolCmd%
