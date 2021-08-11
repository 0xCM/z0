//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-reg-tokens")]
        Outcome RegTokens(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitTokens(AsmTokens.Regs.create());
            return result;
        }
    }
}