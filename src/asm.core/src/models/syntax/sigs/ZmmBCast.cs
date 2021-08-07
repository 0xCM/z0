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
        public readonly struct ZmmBCast
        {
            public ZmmBCastToken Token {get;}

            [MethodImpl(Inline)]
            public ZmmBCast(ZmmBCastToken token)
            {
                Token = token;
            }

            public K Kind => K.ZmmBCast;

            [MethodImpl(Inline)]
            public static implicit operator ZmmBCast(ZmmBCastToken src)
                => new ZmmBCast(src);

            [MethodImpl(Inline)]
            public static implicit operator ZmmBCastToken(ZmmBCast src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(ZmmBCast src)
                => token(src.Kind, src);
        }
    }
}