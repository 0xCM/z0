//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".ds")]
        Outcome Ds(CmdArgs args)
        {
            if(args.Count != 0)
                State.DataSource(SouceWs().Root + FS.file(arg(args,0).Value));
            Write(State.DataSource());
            return true;
        }
    }
}