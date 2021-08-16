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
    using static WsAtoms;

    partial class AsmCmdService
    {
        void EmitTokens(ITokenSet src)
        {
            var dst = Ws.Output().Table<SymToken>(queries, src.Name);
            var tokens = Symbols.tokens(src.Types());
            EmitRecords(tokens, SymToken.RenderWidths, dst);
            var count = tokens.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var token = ref skip(tokens,i);
                Write(string.Format("{0,-16}: {1,-14} - {2}", token.TokenType.Format().Replace("Token", EmptyString), token.Expr, token.Description));
            }
        }
    }
}