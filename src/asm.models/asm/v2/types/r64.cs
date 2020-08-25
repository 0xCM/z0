//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = RegisterKind;

    public readonly struct rax : IRegOperand<rax,W64,ulong>
    {
        public ulong Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R64(rax src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rax(ulong value)
        {
            Content = value;
        }

        public K Kind => K.RAX;

        public R64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R64(Content, Kind);
        }
    }

    public readonly struct rcx : IRegOperand<rcx,W64,ulong>
    {
        public ulong Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R64(rcx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rcx(ulong value)
        {
            Content = value;
        }

        public K Kind => K.RAX;

        public R64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R64(Content, Kind);
        }
    }

    public readonly struct rdx : IRegOperand<rdx,W64,ulong>
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

    public readonly struct rbx : IRegOperand64<rbx,ulong>
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

    public readonly struct rsi : IRegOperand64<rsi,ulong>
    {
        public ulong Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R64(rsi src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rsi(ulong value)
        {
            Content = value;
        }

        public K Kind => K.RSI;

        public R64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R64(Content, Kind);
        }
    }

    public readonly struct rdi : IRegOperand64<rdi,ulong>
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

    public readonly struct rsp : IRegOperand64<rsp,ulong>
    {
        public ulong Content  {get;}

        [MethodImpl(Inline)]
        public rsp(ulong value)
        {
            Content = value;
        }

        public K Kind => K.RSP;

        public R64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R64(Content, Kind);
        }
    }

    public readonly struct rbp : IRegOperand64<rbp,ulong>
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

    public readonly struct r8q : IRegOperand64<r8q,ulong>
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

    public readonly struct r9q : IRegOperand64<r9q,ulong>
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

    public readonly struct r10q : IRegOperand64<r10q,ulong>
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

    public readonly struct r11q : IRegOperand64<r11q,ulong>
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

    public readonly struct r12q : IRegOperand64<r12q,ulong>
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

    public readonly struct r13q : IRegOperand64<r13q,ulong>
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

    public readonly struct r14q : IRegOperand64<r14q,ulong>
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

    public readonly struct r15q : IRegOperand64<r15q,ulong>
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