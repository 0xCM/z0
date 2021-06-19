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
        public readonly struct VMem
        {
            public VMemKind Kind {get;}

            [MethodImpl(Inline)]
            public VMem(VMemKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator VMem(VMemKind src)
                => new VMem(src);

            [MethodImpl(Inline)]
            public static implicit operator VMemKind(VMem src)
                => src.Kind;

            [MethodImpl(Inline)]
            public static implicit operator byte(VMem src)
                => (byte)src.Kind;
        }
    }
}