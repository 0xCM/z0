//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-mc-disasm")]
        Outcome Disasm(CmdArgs args)
        {
            var result = Outcome.Success;
            const string CmdPattern = @"j:\source\llvm\llvm-project\build\bin\llvm-mc.exe --disassemble --x86-asm-syntax=intel --output-asm-variant=1 --print-imm-hex {0} -o {1}";
            var src = Files(FS.Hex).View;
            var count = src.Length;
            var dst = alloc<FS.FilePath>(count);

            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var output = ToolOutDir(Toolspace.llvm_mc) + input.FileName.ChangeExtension(FS.Asm);
                var command = string.Format(CmdPattern, input,output);
                result = RunWinCmd(command, out var response);
                if(result.Fail)
                    return result;
                seek(dst,i) = output;
                Write(FS.flow(input,output));
            }

            Files(dst,false);
            return true;
        }

        /// <summary>
        /// SrcPath,DstPath
        /// </summary>
        const string LlvmMcAssemblePattern = @"j:\source\llvm\llvm-project\build\bin\llvm-mc.exe --assemble --filetype=obj --incremental-linker-compatible --mcpu=skylake-avx512 --target-abi=regcall --triple=x86_64-pc-windows-msvc --x86-asm-syntax=intel --output-asm-variant=1 --print-imm-hex {0} -o {1}";
    }
}