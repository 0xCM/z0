//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tokens-emit")]
        Outcome Tokens(CmdArgs args)
        {
            var result = Outcome.Success;
            Wf.AsmEtl().EmitAsmTokens();

            return result;
        }
    }
}