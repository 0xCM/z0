//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".lists")]
        Outcome ShowLists(CmdArgs args)
        {
            var result = Outcome.Success;
            Files(TableWs().Subdir("lists").AllFiles);
            return result;
        }
    }
}