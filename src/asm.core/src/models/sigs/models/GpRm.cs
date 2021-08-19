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
        public readonly struct GpRm
        {
            public GpRmComposite Token {get;}

            [MethodImpl(Inline)]
            public GpRm(GpRmComposite token)
            {
                Token = token;
            }

            public K Kind => K.GpRm;

            [MethodImpl(Inline)]
            public static implicit operator GpRm(GpRmComposite src)
                => new GpRm(src);

            [MethodImpl(Inline)]
            public static implicit operator GpRmComposite(GpRm src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(GpRm src)
                => token(src.Kind, src);
        }
    }
}