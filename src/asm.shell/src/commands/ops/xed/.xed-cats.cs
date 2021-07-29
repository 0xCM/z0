//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".xed-cats")]
        Outcome XedCategories(CmdArgs args)
        {
            var result = Outcome.Success;

            var src = Xed.Categories();
            WriteSyms(src);
            return result;
        }
    }
}