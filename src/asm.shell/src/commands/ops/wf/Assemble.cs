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
    }
}