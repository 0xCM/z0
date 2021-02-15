//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodeTokens
    {
        public readonly struct VEX
        {
            public string Symbol => "VEX";

            public TokenKind Kind => default;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(VEX src)
                => (src.Symbol, src.Kind);
        }

        public readonly struct x128
        {
            public string Symbol => "128";

            public TokenKind Kind => default;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(x128 src)
                => (src.Symbol, src.Kind);
        }

        public readonly struct x256
        {
            public string Symbol => "256";


            public TokenKind Kind => default;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(x256 src)
                => (src.Symbol, src.Kind);
        }

        public readonly struct NDS
        {
            public string Symbol => "NDS";

            public TokenKind Kind => default;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(NDS src)
                => (src.Symbol, src.Kind);
        }

        public readonly struct LIG
        {
            public string Symbol => "LIG";

            public TokenKind Kind => default;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(LIG src)
                => (src.Symbol, src.Kind);
        }

        public readonly struct REX
        {
            public string Symbol => "REX";

            public TokenKind Kind => default;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(REX src)
                => (src.Symbol, src.Kind);
        }

        public readonly struct HexLiteral
        {
            public Hex8 Value {get;}

            [MethodImpl(Inline)]
            public HexLiteral(Hex8 seq)
                => Value = seq;

            [MethodImpl(Inline)]
            public static implicit operator HexLiteral(byte src)
                => new HexLiteral(src);

            [MethodImpl(Inline)]
            public static implicit operator HexLiteral(Hex8Seq src)
                => new HexLiteral(src);
        }
    }
}