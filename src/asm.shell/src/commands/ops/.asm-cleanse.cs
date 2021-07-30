//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-cleanse")]
        Outcome AsmCleanse(CmdArgs args)
        {
            return CleanseAsm();
        }
    }
}