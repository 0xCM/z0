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
    using G = AsmOpTypes.xmm;
    using K = AsmCodes.XmmReg;

    using api = AsmRegs;

    partial struct AsmOpTypes
    {
        public readonly struct xmm : IRegOp128<xmm>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public xmm(RegIndex index)
            {
                Index = index;
            }

            public string Format()
                => ((K)Index).ToString();

            public override string ToString()
                => Format();

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
                => AsmOps.reg(src.Width, src.RegClass, src.Index);

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
                => api.next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => api.prior(src);
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

        public readonly struct xmm10 : IRegOp128<xmm10>
        {
            public I Index => I.r10;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm10 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm10 src)
                => (K)src.Index;
        }

        public readonly struct xmm11 : IRegOp128<xmm11>
        {
            public I Index => I.r11;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm11 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm11 src)
                => (K)src.Index;
        }

        public readonly struct xmm12 : IRegOp128<xmm12>
        {
            public I Index => I.r12;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm12 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm12 src)
                => (K)src.Index;
        }

        public readonly struct xmm13 : IRegOp128<xmm13>
        {
            public I Index => I.r13;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm13 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm13 src)
                => (K)src.Index;
        }

        public readonly struct xmm14 : IRegOp128<xmm14>
        {
            public I Index => I.r14;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm14 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm14 src)
                => (K)src.Index;
        }

        public readonly struct xmm15 : IRegOp128<xmm15>
        {
            public I Index => I.r15;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm15 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm15 src)
                => (K)src.Index;
        }

        public readonly struct xmm16 : IRegOp128<xmm16>
        {
            public I Index => I.r16;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm16 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm16 src)
                => (K)src.Index;
        }

        public readonly struct xmm17 : IRegOp128<xmm17>
        {
            public I Index => I.r17;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm17 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm17 src)
                => (K)src.Index;
        }

        public readonly struct xmm18 : IRegOp128<xmm18>
        {
            public I Index => I.r18;

            [MethodImpl(Inline)]
            public static implicit operator G(xmm18 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(xmm18 src)
                => (K)src.Index;
        }

    }
}