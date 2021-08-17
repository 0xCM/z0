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
        public readonly struct VecReg
        {
            public VecRegToken Token {get;}

            [MethodImpl(Inline)]
            public VecReg(VecRegToken token)
            {
                Token = token;
            }

            public K Kind => K.VecReg;

            [MethodImpl(Inline)]
            public static implicit operator VecReg(VecRegToken src)
                => new VecReg(src);

            [MethodImpl(Inline)]
            public static implicit operator VecRegToken(VecReg src)
                => src.Token;

            [MethodImpl(Inline)]
            public static implicit operator AsmSigToken(VecReg src)
                => token(src.Kind, src);
        }
    }
}