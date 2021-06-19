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
        public readonly struct Imm
        {
            public ImmKind Kind {get;}

            [MethodImpl(Inline)]
            public Imm(ImmKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator Imm(ImmKind src)
                => new Imm(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmKind(Imm src)
                => src.Kind;

            [MethodImpl(Inline)]
            public static implicit operator byte(Imm src)
                => (byte)src.Kind;
        }
    }
}