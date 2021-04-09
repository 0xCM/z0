//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmLang;

    using I = RegIndex;
    using G = AsmOps.r32;
    using K = AsmLang.Gp32;

    partial struct AsmOps
    {
        public readonly struct r32 : IRegOp32<r32>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public r32(RegIndex index)
            {
                Index = index;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => new RegOp(RegWidth.W32, RegClass.GP, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);

            [MethodImpl(Inline)]
            public static explicit operator byte(G src)
                => (byte)src.Index;
        }

        public readonly struct eax : IRegOp32<eax>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(eax src)
                => new G(src.Index);
        }

        public struct ecx : IRegOp32<ecx>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(ecx src)
                => new G(src.Index);
        }

        public struct edx : IRegOp32<edx>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(edx src)
                => new G(src.Index);
        }

        public struct ebx : IRegOp32<ebx>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(ebx src)
                => new G(src.Index);
        }

        public struct esi : IRegOp32<esi>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(esi src)
                => new G(src.Index);
        }

        public struct edi : IRegOp32<edi>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(edi src)
                => new G(src.Index);
        }

        public struct esp : IRegOp32<esp>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(esp src)
                => new G(src.Index);
        }

        public struct ebp : IRegOp32<ebp>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(ebp src)
                => new G(src.Index);
        }

        public struct r8d : IRegOp32<r8d>
        {
            public I Index => I.r8;

            [MethodImpl(Inline)]
            public static implicit operator G(r8d src)
                => new G(src.Index);
        }

        public struct r9d : IRegOp32<r9d>
        {
            public I Index => I.r9;

            [MethodImpl(Inline)]
            public static implicit operator G(r9d src)
                => new G(src.Index);
        }

        public struct r10d : IRegOp32<r10d>
        {
            public I Index => I.r10;

            [MethodImpl(Inline)]
            public static implicit operator G(r10d src)
                => new G(src.Index);
        }

        public struct r11d : IRegOp32<r11d>
        {
            public I Index => I.r11;

            [MethodImpl(Inline)]
            public static implicit operator G(r11d src)
                => new G(src.Index);
        }

        public struct r12d : IRegOp32<r12d>
        {
            public I Index => I.r12;

            [MethodImpl(Inline)]
            public static implicit operator G(r12d src)
                => new G(src.Index);
        }

        public struct r13d : IRegOp32<r13d>
        {
            public I Index => I.r13;

            [MethodImpl(Inline)]
            public static implicit operator G(r13d src)
                => new G(src.Index);
        }

        public struct r14d : IRegOp32<r14d>
        {
            public I Index => I.r14;

            [MethodImpl(Inline)]
            public static implicit operator G(r14d src)
                => new G(src.Index);
        }

        public struct r15d : IRegOp32<r15d>
        {
            public I Index => I.r15;

            [MethodImpl(Inline)]
            public static implicit operator G(r15d src)
                => new G(src.Index);
        }
    }
}