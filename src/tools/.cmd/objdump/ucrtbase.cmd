echo off
set ToolName=objdump
set SrcName=ucrtbase
set SrcFile=%SrcName%.dll
set SrcDir=%core_root%
set SrcPath=%SrcDir%\%SrcFile%
set DstFile=%SrcName%.asm
set OutPath=%ZDb%\tools\%ToolName%\output\%DstFile%
set ToolOptions=--all-headers --syms --reloc --file-offsets --disassemble-all --wide --disassemble-zeroes --disassembler-options=intel,intel-mnemonic,intel64
set ToolOptions=--disassemble-all --wide --disassemble-zeroes --disassembler-options=intel,intel-mnemonic,intel64
set ToolOptions=--all-headers --reloc --file-offsets
set ToolCmd=%ToolName% %ToolOptions% %SrcPath%

echo on
call %ToolCmd% > %OutPath%

