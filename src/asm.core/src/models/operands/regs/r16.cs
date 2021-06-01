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
    using G = AsmOps.r16;
    using K = AsmRegCodes.Gp16;
    using api = AsmRegs;

    partial struct AsmOps
    {
        public readonly struct r16 : IRegOp16<r16>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public r16(RegIndex index)
            {
                Index = index;
            }

            public override string ToString()
                => ((K)Index).ToString();


            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => RegWidth.W16;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.GP;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => AsmOp.reg(src.Width, src.RegClass, src.Index);

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
            public static explicit operator byte(G src)
                => (byte)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(Sym<K> src)
                => new G((I)src.Kind);

            [MethodImpl(Inline)]
            public static G operator ++(G src)
                => api.next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => api.prior(src);
        }

        public readonly struct ax : IRegOp16<ax>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator r16(ax src)
                => new r16(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(ax src)
                => (K)src.Index;

        }

        public struct cx : IRegOp16<cx>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(cx src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cx src)
                => (K)src.Index;
        }

        public struct dx : IRegOp16<dx>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(dx src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(dx src)
                => (K)src.Index;
        }

        public struct bx : IRegOp16<bx>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(bx src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(bx src)
                => (K)src.Index;
        }

        public struct si : IRegOp16<si>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(si src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(si src)
                => (K)src.Index;
        }

        public struct di : IRegOp16<di>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(di src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(di src)
                => (K)src.Index;
        }

        public struct sp : IRegOp16<sp>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(sp src)
                => new G(src.Index);
        }

        public struct bp : IRegOp16<bp>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(bp src)
                => new G(src.Index);
        }

        public struct r8w : IRegOp16<r8w>
        {
            public I Index => I.r8;

            [MethodImpl(Inline)]
            public static implicit operator G(r8w src)
                => new G(src.Index);
        }

        public struct r9w : IRegOp16<r9w>
        {
            public I Index => I.r9;

            [MethodImpl(Inline)]
            public static implicit operator G(r9w src)
                => new G(src.Index);
        }

        public struct r10w : IRegOp16<r10w>
        {
            public I Index => I.r10;

            [MethodImpl(Inline)]
            public static implicit operator G(r10w src)
                => new G(src.Index);
        }

        public struct r11w : IRegOp16<r11w>
        {
            public I Index => I.r11;

            [MethodImpl(Inline)]
            public static implicit operator G(r11w src)
                => new G(src.Index);
        }

        public struct r12w : IRegOp16<r12w>
        {
            public I Index => I.r12;

            [MethodImpl(Inline)]
            public static implicit operator G(r12w src)
                => new G(src.Index);
        }

        public struct r13w : IRegOp16<r13w>
        {
            public I Index => I.r13;

            [MethodImpl(Inline)]
            public static implicit operator G(r13w src)
                => new G(src.Index);
        }

        public struct r14w : IRegOp16<r14w>
        {
            public I Index => I.r14;

            [MethodImpl(Inline)]
            public static implicit operator G(r14w src)
                => new G(src.Index);
        }

        public struct r15w : IRegOp16<r15w>
        {
            public I Index => I.r15;

            [MethodImpl(Inline)]
            public static implicit operator G(r15w src)
                => new G(src.Index);
        }
    }
}