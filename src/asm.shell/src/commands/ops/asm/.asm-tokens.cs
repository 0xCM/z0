//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-tokens")]
        Outcome Tokens(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitTokens(AsmTokens.Codes.create());
            EmitTokens(AsmTokens.Regs.create());

            return result;
        }
    }
}