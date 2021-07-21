//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tables")]
        Outcome Tables(CmdArgs args)
        {
            var outcome = Outcome.Success;
            if(args.Count !=0)
                Tables(FS.dir(arg(args,0)));
            Write(Tables().Root);
            return true;
        }

    }
}