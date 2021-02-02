//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodeModel
    {
        public readonly struct OpCodeToken
        {
            public TextBlock Expression {get;}

            [MethodImpl(Inline)]
            public OpCodeToken(string src)
            {
                Expression = src;
            }
        }

        public readonly struct VEX
        {
            public string Name => "VEX";

            [MethodImpl(Inline)]
            public static implicit operator OpCodeToken(VEX src)
                => new OpCodeToken(src.Name);
        }

        public readonly struct x128
        {
            public string Name => "128";

            [MethodImpl(Inline)]
            public static implicit operator OpCodeToken(x128 src)
                => new OpCodeToken(src.Name);
        }

        public readonly struct x256
        {
            public string Name => "256";

            [MethodImpl(Inline)]
            public static implicit operator OpCodeToken(x256 src)
                => new OpCodeToken(src.Name);
        }

        public readonly struct NDS
        {
            public string Name => "NDS";

            [MethodImpl(Inline)]
            public static implicit operator OpCodeToken(NDS src)
                => new OpCodeToken(src.Name);
        }

        public readonly struct LIG
        {
            public string Name => "LIG";

            [MethodImpl(Inline)]
            public static implicit operator OpCodeToken(LIG src)
                => new OpCodeToken(src.Name);
        }

        public readonly struct REX
        {
            public string Name => "REX";

            [MethodImpl(Inline)]
            public static implicit operator OpCodeToken(REX src)
                => new OpCodeToken(src.Name);
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