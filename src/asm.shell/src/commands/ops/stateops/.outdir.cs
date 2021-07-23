//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".outdir")]
        Outcome DstDir(CmdArgs args)
        {
            if(args.Length == 0)
                Write(State.OutDir());
            else
                Write(State.OutDir(arg(args,0).Value));
            return true;
        }
    }
}