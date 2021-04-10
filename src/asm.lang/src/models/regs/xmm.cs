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
    using G = AsmOps.xmm;
    using K = AsmX.XmmReg;

    partial struct AsmOps
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
            public static implicit operator RegOp(G src)
                => new RegOp(RegWidth.W128, RegClass.XMM, src.Index);

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

        public readonly struct xmm1 : IRegOp128<xmm1>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm1 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm1 src)
                => (K)src.Index;
        }

        public readonly struct xmm2 : IRegOp128<xmm2>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm2 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm2 src)
                => (K)src.Index;
        }

        public readonly struct xmm3 : IRegOp128<xmm3>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm3 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm3 src)
                => (K)src.Index;
        }

        public readonly struct xmm4 : IRegOp128<xmm4>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm4 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm4 src)
                => (K)src.Index;
        }

        public readonly struct xmm5 : IRegOp128<xmm5>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm5 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm5 src)
                => (K)src.Index;
        }

    }
}