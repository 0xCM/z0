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
    using G = AsmOps.r64;
    using K = AsmRegCodes.Gp64;

    partial struct AsmOps
    {
        public readonly struct r64 : IRegOp64<r64>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public r64(I index)
            {
                Index = index;
            }

            public override string ToString()
                => ((K)Index).ToString();

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => RegWidth.W64;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.GP;
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
            public static implicit operator G(uint4 src)
                => new G((I)(byte)src);

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
                => next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => prior(src);
        }

        public readonly struct rax : IRegOp64<rax>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(rax src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rax src)
                => (K)src.Index;
        }

        public struct rcx : IRegOp64<rcx>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(rcx src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rcx src)
                => (K)src.Index;
        }

        public struct rdx : IRegOp64<rdx>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(rdx src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rdx src)
                => (K)src.Index;
        }

        public struct rbx : IRegOp64<rbx>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(rbx src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rbx src)
                => (K)src.Index;
        }

        public struct rsi : IRegOp64<rsi>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(rsi src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rsi src)
                => (K)src.Index;
        }

        public struct rdi : IRegOp64<rdi>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(rdi src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rdi src)
                => (K)src.Index;
        }

        public struct rsp : IRegOp64<rsp>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(rsp src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rsp src)
                => (K)src.Index;
        }

        public struct rbp : IRegOp64<rbp>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(rbp src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(rbp src)
                => (K)src.Index;
        }

        public struct r8q : IRegOp64<r8q>
        {
            public I Index => I.r8;

            [MethodImpl(Inline)]
            public static implicit operator G(r8q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r8q src)
                => (K)src.Index;
        }

        public struct r9q : IRegOp64<r9q>
        {
            public I Index => I.r9;

            [MethodImpl(Inline)]
            public static implicit operator G(r9q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r9q src)
                => (K)src.Index;
        }

        public struct r10q : IRegOp64<r10q>
        {
            public I Index => I.r10;

            [MethodImpl(Inline)]
            public static implicit operator G(r10q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r10q src)
                => (K)src.Index;
        }

        public struct r11q : IRegOp64<r11q>
        {
            public I Index => I.r11;

            [MethodImpl(Inline)]
            public static implicit operator G(r11q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r11q src)
                => (K)src.Index;
        }

        public struct r12q : IRegOp64<r12q>
        {
            public I Index => I.r12;

            [MethodImpl(Inline)]
            public static implicit operator G(r12q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r12q src)
                => (K)src.Index;
        }

        public struct r13q : IRegOp64<r13q>
        {
            public I Index => I.r13;

            [MethodImpl(Inline)]
            public static implicit operator G(r13q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r13q src)
                => (K)src.Index;
        }

        public struct r14q : IRegOp64<r14q>
        {
            public I Index => I.r14;

            [MethodImpl(Inline)]
            public static implicit operator G(r14q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r14q src)
                => (K)src.Index;

        }

        public struct r15q : IRegOp64<r15q>
        {
            public I Index => I.r15;

            [MethodImpl(Inline)]
            public static implicit operator G(r15q src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(r15q src)
                => (K)src.Index;
        }
    }
}