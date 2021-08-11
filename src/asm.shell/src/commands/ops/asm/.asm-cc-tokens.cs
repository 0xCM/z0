//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-cc-tokens")]
        Outcome CcTokens(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitTokens(AsmTokens.Conditions.create());
            return result;
        }
    }
}