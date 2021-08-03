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
        public readonly struct Mem
        {
            public MemToken Token {get;}

            [MethodImpl(Inline)]
            public Mem(MemToken token)
            {
                Token = token;
            }

            public K Kind => K.Mem;

            [MethodImpl(Inline)]
            public static implicit operator Mem(MemToken src)
                => new Mem(src);

            [MethodImpl(Inline)]
            public static implicit operator MemToken(Mem src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(Mem src)
                => token(src.Kind, src);
        }
    }
}