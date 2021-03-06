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
        public readonly struct MaskReg
        {
            public MaskRegToken Token {get;}

            [MethodImpl(Inline)]
            public MaskReg(MaskRegToken token)
            {
                Token = token;
            }

            public K Kind => K.MaskReg;

            [MethodImpl(Inline)]
            public static implicit operator MaskReg(MaskRegToken src)
                => new MaskReg(src);

            [MethodImpl(Inline)]
            public static implicit operator MaskRegToken(MaskReg src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(MaskReg src)
                => token(src.Kind, src);
        }
    }
}