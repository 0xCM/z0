//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using I = RegIndex;
    using G = AsmRegOps.xmm;
    using K = XmmReg;

    partial struct AsmRegOps
    {
        public readonly struct xmm : IRegOp128<xmm>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public xmm(RegIndex index)
            {
                Index = index;
            }

            [MethodImpl(Inline)]
            public static implicit operator AsmRegOp(G src)
                => new AsmRegOp(RegWidth.W128, RegClass.XMM, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);
        }

        public readonly struct xmm0 : IRegOp128<xmm0>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm0 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm0 src)
                => (K)src.Index;
        }

    }
}