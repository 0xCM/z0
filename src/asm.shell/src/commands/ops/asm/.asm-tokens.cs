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
            EmitTokens(AsmTokens.OpCodes.create());
            EmitTokens(AsmTokens.Sigs.create());
            EmitTokens(AsmTokens.Codes.create());
            EmitTokens(AsmTokens.Regs.create());
            EmitTokens(AsmTokens.Conditions.create());

            return result;
        }
    }
}