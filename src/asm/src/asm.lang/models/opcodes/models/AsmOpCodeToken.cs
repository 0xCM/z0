//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodes
    {
        public readonly struct AsmOpCodeToken
        {
            public string Symbol {get;}

            public OpCodeTokenKind Kind {get;}

            public string Description {get;}

            [MethodImpl(Inline)]
            public AsmOpCodeToken(string symbol, OpCodeTokenKind kind, string description)
            {
                Symbol = symbol;
                Kind  = kind;
                Description = description;
            }

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken((string symbol, OpCodeTokenKind kind) src)
                => new AsmOpCodeToken(src.symbol, src.kind, EmptyString);

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken((string symbol, OpCodeTokenKind kind, string description) src)
                => new AsmOpCodeToken(src.symbol, src.kind, src.description);

        }
    }
}