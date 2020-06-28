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
    
    public readonly struct rax : IRegOp64<rax,N0>
    {        
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r64(rax src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rax(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RAX;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }

    public readonly struct rcx : IRegOp64<rcx,N1>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r64(rcx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rcx(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RAX;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }    

    public readonly struct rdx : IRegOp64<rdx,N2>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r64(rdx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rdx(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RDX;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }    

    public readonly struct rbx : IRegOp64<rbx,N3>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r64(rbx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rbx(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RBX;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }    

    public readonly struct rsi : IRegOp64<rsi,N4>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r64(rsi src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public rsi(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RSI;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }    

    public readonly struct rdi : IRegOp64<rdi,N5>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public rdi(ulong value)
        {
            Value = value;
        }
        
        public K Kind => K.RDI;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }        

    public readonly struct rsp : IRegOp64<rsp,N6>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public rsp(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RSP;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }            

    public readonly struct rbp : IRegOp64<rbp,N7>
    {            
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public rbp(ulong value)
        {
            Value = value;
        }

        public K Kind => K.RBP;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                

    public readonly struct r8q : IRegOp64<r8q,N8>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r8q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R8Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                    

    public readonly struct r9q : IRegOp64<r9q,N9>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r9q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R9Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                        

    public readonly struct r10q : IRegOp64<r10q,N10>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r10q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R10Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                        

    public readonly struct r11q : IRegOp64<r11q,N11>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r11q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R11Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                        

    public readonly struct r12q : IRegOp64<r12q,N12>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r12q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R12Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                    

    public readonly struct r13q : IRegOp64<r13q,N13>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r13q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R13Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                        

    public readonly struct r14q : IRegOp64<r14q,N14>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r14q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R14Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    }                        

    public readonly struct r15q : IRegOp64<r15q,N15>
    {
        public ulong Value  {get;}

        [MethodImpl(Inline)]
        public r15q(ulong value)
        {
            Value = value;
        }

        public K Kind => K.R15Q;

        public r64 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r64(Value, Kind);
        }
    } 
}