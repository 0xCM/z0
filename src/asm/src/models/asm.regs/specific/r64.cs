//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = RegisterKind;

    partial struct XRegisters
    {
        public struct rax : IRegister<rax,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator R64(rax src)
                => new R64(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rax(ulong value)
                => Data = value;

            public K Kind => K.RAX;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public struct rcx : IRegister<rcx,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator R64(rcx src)
                => new R64(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rcx(ulong value)
                => Data = value;

            public K Kind => K.RAX;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get => new R64(Content, Kind);
            }
        }

        public struct rdx : IRegister<rdx,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator R64(rdx src)
                => new R64(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rdx(ulong value)
                => Data = value;

            public K Kind => K.RDX;
        }

        public struct rbx : IRegister<rbx,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator R64(rbx src)
                => new R64(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rbx(ulong value)
                => Data = value;

            public K Kind => K.RBX;
        }

        public struct rsi : IRegister<rsi,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator R64(rsi src)
                => new R64(src.Content, src.Kind);

            [MethodImpl(Inline)]
            public rsi(ulong value)
                => Data = value;

            public K Kind => K.RSI;

        }

        public struct rdi : IRegister<rdi,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public rdi(ulong value)
                => Data = value;

            public K Kind => K.RDI;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R64(rdi src)
                => new R64(src.Content, src.Kind);
        }

        public struct rsp : IRegister<rsp,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public rsp(ulong value)
                 => Data = value;

            public K Kind => K.RSP;

            [MethodImpl(Inline)]
            public static implicit operator R64(rsp src)
                => new R64(src.Content, src.Kind);
        }

        public struct rbp : IRegister<rbp,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public rbp(ulong value)
                => Data = value;

            public K Kind => K.RBP;

            [MethodImpl(Inline)]
            public static implicit operator R64(rbp src)
                => new R64(src.Content, src.Kind);
        }

        public struct r8q : IRegister<r8q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r8q(ulong value)
                => Data = value;

            public K Kind => K.R8Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r8q src)
                => new R64(src.Content, src.Kind);
        }

        public struct r9q : IRegister<r9q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r9q(ulong value)
                => Data = value;

            public K Kind => K.R9Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r9q src)
                => new R64(src.Content, src.Kind);

        }

        public struct r10q : IRegister<r10q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r10q(ulong value)
                => Data = value;

            public K Kind => K.R10Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r10q src)
                => new R64(src.Content, src.Kind);

        }

        public struct r11q : IRegister<r11q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r11q(ulong value)
                => Data = value;

            public K Kind => K.R11Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r11q src)
                => new R64(src.Content, src.Kind);
        }

        public struct r12q : IRegister<r12q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r12q(ulong value)
                => Data = value;

            public K Kind => K.R12Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r12q src)
                => new R64(src.Content, src.Kind);

        }

        public struct r13q : IRegister<r13q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r13q(ulong value)
                => Data = value;

            public K Kind => K.R13Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r13q src)
                => new R64(src.Content, src.Kind);
        }

        public struct r14q : IRegister<r14q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r14q(ulong value)
                => Data = value;

            public K Kind => K.R14Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r14q src)
                => new R64(src.Content, src.Kind);

        }

        public struct r15q : IRegister<r15q,W64,ulong>
        {
            public ulong Data;

            public ulong Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public r15q(ulong value)
                => Data = value;

            public K Kind => K.R15Q;

            [MethodImpl(Inline)]
            public static implicit operator R64(r15q src)
                => new R64(src.Content, src.Kind);
        }
    }
}