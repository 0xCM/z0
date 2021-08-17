//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".tokens-emit")]
        Outcome Tokens(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitTokens(AsmTokens.Codes.create());
            EmitTokens(AsmTokens.Regs.create());
            EmitTokens(AsmTokens.Conditions.create());
            EmitTokens(AsmTokens.Regs.create());
            EmitTokens(AsmTokens.Sigs.create());
            EmitTokens(AsmTokens.OpCodes.create());

            return result;
        }

        void EmitTokens(ITokenSet src)
        {
            const string Expression = "{0,-16}: {1,-14} - {2}";
            var dst = TableWs().Table<SymToken>(WsAtoms.tokens, src.Name);
            var tokens = Symbols.tokens(src.Types());
            EmitRecords(tokens, SymToken.RenderWidths, dst);
            var count = tokens.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref skip(tokens,i);
                var name = token.TokenType.Format().Replace("Token", EmptyString);
                Write(string.Format(Expression, name, token.Expr, token.Description));
            }
        }
    }
}