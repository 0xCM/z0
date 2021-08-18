//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".tokenize")]
        Outcome TestTokenize(CmdArgs args)
        {
            var result = Outcome.Success;
            //var _tokens = Z0.Tokens.tokenize(typeof(AsmOpCodeTokens.ModRmToken));
            var tokens = AsmOpCodes.TokenSet();
            var count = tokens.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref skip(tokens,i);
                Write(token);
            }

            return result;
        }

    }
}