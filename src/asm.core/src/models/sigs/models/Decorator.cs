//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    using K = AsmSigTokenKind;

    partial class AsmSigs
    {
        public readonly struct Decorator
        {
            public RoundingToken Token {get;}

            [MethodImpl(Inline)]
            public Decorator(RoundingToken token)
            {
                Token = token;
            }

            public K Kind => K.Rounding;

            [MethodImpl(Inline)]
            public static implicit operator Decorator(RoundingToken src)
                => new Decorator(src);

            [MethodImpl(Inline)]
            public static implicit operator RoundingToken(Decorator src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(Decorator src)
                => token(src.Kind, src);
        }
    }
}