//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".srcdir")]
        Outcome SrcDir(CmdArgs args)
        {
            if(args.Length == 0)
                Write(SrcDir());
            else
                Write(SrcDir(FS.dir(arg(args,0).Value)));
            return true;
        }
    }
}