//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".srclist")]
        Outcome SrcList(CmdArgs args)
        {
            if(args.Count !=0)
            {
                if(Arg(args,0,out var pattern))
                    Files(State.SrcDir().Files(pattern.Value,false));
            }
            else
                Files(State.SrcDir().AllFiles);
            return true;
        }
    }
}