//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        Outcome Assemble()
        {
            var src = Files(FS.Asm).View;
            var result = Outcome.Success;
            var count = src.Length;
            var output = list<FS.FilePath>();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var spec = AsmWs.ToolchainSpec(Toolspace.nasm, Toolspace.bddiasm, path);
                result = AsmToolchain.Run(spec);
                if(result.Fail)
                    return result;

                output.Add(path);
                output.Add(spec.BinPath);
                output.Add(spec.ObjPath);
            }

            Files(output.ToArray(), false);

            return DumpObjects();
        }

        /// <summary>
        /// SrcPath,DstPath
        /// </summary>
        const string LlvmMcAssemblePattern = @"j:\source\llvm\llvm-project\build\bin\llvm-mc.exe --assemble --filetype=obj --incremental-linker-compatible --mcpu=skylake-avx512 --target-abi=regcall --triple=x86_64-pc-windows-msvc --x86-asm-syntax=intel --output-asm-variant=1 --print-imm-hex {0} -o {1}";
    }
}