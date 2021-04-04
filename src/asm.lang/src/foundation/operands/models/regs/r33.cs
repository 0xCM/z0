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
    using G = AsmRegOps.r64;

    partial struct AsmRegOps
    {
        public readonly struct r64 : IRegOp32<r64>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public r64(RegIndex index)
            {
                Index = index;
            }

            [MethodImpl(Inline)]
            public static implicit operator AsmRegOp(r64 src)
                => new AsmRegOp(RegWidth.W64, RegClass.GP, src.Index);
        }

        public readonly struct rax : IRegOp32<rax>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(rax src)
                => new G(src.Index);
        }

        public struct rcx : IRegOp32<rcx>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(rcx src)
                => new G(src.Index);
        }

        public struct rdx : IRegOp32<rdx>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(rdx src)
                => new G(src.Index);
        }

        public struct rbx : IRegOp32<rbx>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(rbx src)
                => new G(src.Index);
        }

        public struct rsi : IRegOp32<rsi>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(rsi src)
                => new G(src.Index);
        }

        public struct rdi : IRegOp32<rdi>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(rdi src)
                => new G(src.Index);
        }

        public struct rsp : IRegOp32<rsp>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(rsp src)
                => new G(src.Index);
        }

        public struct rbp : IRegOp32<rbp>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(rbp src)
                => new G(src.Index);
        }

        public struct r8q : IRegOp32<r8q>
        {
            public I Index => I.r8;

            [MethodImpl(Inline)]
            public static implicit operator G(r8q src)
                => new G(src.Index);
        }

        public struct r9q : IRegOp32<r9q>
        {
            public I Index => I.r9;

            [MethodImpl(Inline)]
            public static implicit operator G(r9q src)
                => new G(src.Index);
        }

        public struct r10q : IRegOp32<r10q>
        {
            public I Index => I.r10;

            [MethodImpl(Inline)]
            public static implicit operator G(r10q src)
                => new G(src.Index);
        }

        public struct r11q : IRegOp32<r11q>
        {
            public I Index => I.r11;

            [MethodImpl(Inline)]
            public static implicit operator G(r11q src)
                => new G(src.Index);
        }

        public struct r12q : IRegOp32<r12q>
        {
            public I Index => I.r12;

            [MethodImpl(Inline)]
            public static implicit operator G(r12q src)
                => new G(src.Index);
        }

        public struct r13q : IRegOp32<r13q>
        {
            public I Index => I.r13;

            [MethodImpl(Inline)]
            public static implicit operator G(r13q src)
                => new G(src.Index);
        }

        public struct r14q : IRegOp32<r14q>
        {
            public I Index => I.r14;

            [MethodImpl(Inline)]
            public static implicit operator G(r14q src)
                => new G(src.Index);
        }

        public struct r15q : IRegOp32<r15q>
        {
            public I Index => I.r15;

            [MethodImpl(Inline)]
            public static implicit operator G(r15q src)
                => new G(src.Index);
        }
    }
}