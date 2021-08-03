//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmSigTokens;

    using K = AsmSigTokenKind;

    partial class AsmSigs
    {
        public readonly struct Imm
        {
            public ImmToken Token {get;}

            [MethodImpl(Inline)]
            public Imm(ImmToken token)
            {
                Token = token;
            }

            public K Kind => K.Imm;

            [MethodImpl(Inline)]
            public static implicit operator Imm(ImmToken src)
                => new Imm(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmToken(Imm src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(Imm src)
                => token(src.Kind, src);
        }
    }
}