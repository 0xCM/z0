//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".receiver")]
        Outcome Receiver(CmdArgs args)
        {
            var result = Outcome.Success;
            return result;
        }
    }
}