//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using SR = SymbolicRender;

    partial class AsmCmdService
    {
        [CmdOp(".algs")]
        Outcome Algs(CmdArgs args)
        {
            var match = arg(args,0).Value;
            var imports = WsDefine(WsScopes.imports).Subdir("intrinsics.alg");
            var paths = imports.Files(match,FS.Alg, false).View;
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                Write(string.Format("# Source:{0}", path));
                Write(string.Format("# {0}",RP.PageBreak120));
                using var reader = path.AsciLineReader();
                while(reader.Next(out var line))
                {
                    Write(SR.format(line.Content));
                }
            }
            return true;
        }

    }
}