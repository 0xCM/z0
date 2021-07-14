//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".algs")]
        Outcome Algs(CmdArgs args)
        {
            var match = arg(args,0).Value;
            var paths = Workspace.AlgImportPaths(match);
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                using var reader = path.AsciLineReader();
                while(reader.Next(out var line))
                {
                    Write(line.Format());
                }
            }
            return true;
        }
    }
}