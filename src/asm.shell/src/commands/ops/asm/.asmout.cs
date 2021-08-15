//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asmout")]
        Outcome AsmOut(CmdArgs args)
        {
            var result = Outcome.Success;
            if(args.Length == 0)
                Files(AsmOutFiles());
            else
                Files(AsmOutFiles(arg(args,0).Value));
            return result;
        }
    }
}