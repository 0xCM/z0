//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmSigTokens
    {
        public readonly struct Reg
        {
            public RegKind Kind {get;}

            [MethodImpl(Inline)]
            public Reg(RegKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator Reg(RegKind src)
                => new Reg(src);

            [MethodImpl(Inline)]
            public static implicit operator RegKind(Reg src)
                => src.Kind;

            [MethodImpl(Inline)]
            public static implicit operator byte(Reg src)
                => (byte)src.Kind;
        }
    }
}