//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmOpCodeTokens;

    public readonly struct AsmOpCodeToken
    {
        public string Symbol {get;}

        public TokenKind Kind {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeToken(string symbol, TokenKind kind, string description)
        {
            Symbol = symbol;
            Kind  = kind;
            Description = description;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeToken((string symbol, TokenKind kind) src)
            => new AsmOpCodeToken(src.symbol, src.kind, EmptyString);
    }
}