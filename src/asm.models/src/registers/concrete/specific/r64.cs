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

    partial struct AsmRegisters
    {
        public readonly struct rax : IRegister<rax,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator R64(rax src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public rax(ulong value)
                => Content = value;

            public K Kind => K.RAX;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rcx : IRegister<rcx,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator R64(rcx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public rcx(ulong value)
                => Content = value;

            public K Kind => K.RAX;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rdx : IRegister<rdx,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator R64(rdx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public rdx(ulong value)
            {
                Content = value;
            }

            public K Kind => K.RDX;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rbx : IRegister<rbx,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator R64(rbx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public rbx(ulong value)
            {
                Content = value;
            }

            public K Kind => K.RBX;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rsi : IRegister<rsi,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator R64(rsi src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public rsi(ulong value)
                => Content = value;

            public K Kind => K.RSI;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rdi : IRegister<rdi,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public rdi(ulong value)
            {
                Content = value;
            }

            public K Kind => K.RDI;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rsp : IRegister<rsp,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public rsp(ulong value)
                => Content = value;

            public K Kind => K.RSP;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct rbp : IRegister<rbp,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public rbp(ulong value)
            {
                Content = value;
            }

            public K Kind => K.RBP;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r8q : IRegister<r8q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r8q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R8Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r9q : IRegister<r9q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r9q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R9Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r10q : IRegister<r10q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r10q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R10Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r11q : IRegister<r11q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r11q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R11Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r12q : IRegister<r12q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r12q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R12Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r13q : IRegister<r13q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r13q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R13Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r14q : IRegister<r14q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r14q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R14Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }

        public readonly struct r15q : IRegister<r15q,W64,ulong>
        {
            public ulong Content  {get;}

            [MethodImpl(Inline)]
            public r15q(ulong value)
            {
                Content = value;
            }

            public K Kind => K.R15Q;

            public R64 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R64(Content, Kind);
            }
        }
    }
}