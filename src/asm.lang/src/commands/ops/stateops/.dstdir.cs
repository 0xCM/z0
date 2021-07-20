//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".dstdir")]
        Outcome DstDir(CmdArgs args)
        {
            if(args.Length == 0)
                Write(DstDir());
            else
                Write(DstDir(FS.dir(arg(args,0).Value)));
            return true;
        }
    }
}