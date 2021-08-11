//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-sig-tokens")]
        Outcome SigTokens(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitTokens(AsmTokens.Sigs.create());
            return result;
        }
    }
}