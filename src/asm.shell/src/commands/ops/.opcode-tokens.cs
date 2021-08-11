//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".opcode-tokens")]
        public Outcome OpCodeTokens(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitTokens(AsmTokens.OpCodes.create());
            return result;
        }
    }
}