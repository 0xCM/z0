//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using I = RegIndex;
    using G = AsmOps.xmm;
    using K = AsmRegCodes.XmmReg;

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

            public override string ToString()
                => ((K)Index).ToString();

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => RegWidth.W128;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.XMM;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => new RegOp(src.Width, src.RegClass, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);

            [MethodImpl(Inline)]
            public static implicit operator G(I src)
                => new G(src);

            [MethodImpl(Inline)]
            public static G operator ++(G src)
                => next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => prior(src);
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

        public readonly struct xmm6 : IRegOp128<xmm6>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm6 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm6 src)
                => (K)src.Index;
        }

        public readonly struct xmm7 : IRegOp128<xmm7>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm7 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm7 src)
                => (K)src.Index;
        }

        public readonly struct xmm8 : IRegOp128<xmm8>
        {
            public I Index => I.r8;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm8 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm8 src)
                => (K)src.Index;
        }

        public readonly struct xmm9 : IRegOp128<xmm9>
        {
            public I Index => I.r9;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm9 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm9 src)
                => (K)src.Index;
        }

    }
}