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
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rax(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RAX;
    }

    public readonly struct rcx : IRegOp64<rcx,N1>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rcx(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RAX;
    }    

    public readonly struct rdx : IRegOp64<rdx,N2>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rdx(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RDX;
    }    

    public readonly struct rbx : IRegOp64<rbx,N3>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rbx(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RBX;
    }    

    public readonly struct rsi : IRegOp64<rsi,N4>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rsi(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RSI;
    }    

    public readonly struct rdi : IRegOp64<rdi,N5>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rdi(Fixed64 value)
        {
            Value = value;
        }
        
        public K Kind => K.RDI;
    }        

    public readonly struct rsp : IRegOp64<rsp,N6>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rsp(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RSP;
    }            

    public readonly struct rbp : IRegOp64<rbp,N7>
    {            
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public rbp(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.RBP;
    }                

    public readonly struct r8q : IRegOp64<r8q,N8>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r8q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R8q;
    }                    

    public readonly struct r9q : IRegOp64<r9q,N9>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r9q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R9q;
    }                        

    public readonly struct r10q : IRegOp64<r10q,N10>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r10q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R10q;
    }                        

    public readonly struct r11q : IRegOp64<r11q,N11>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r11q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R11q;
    }                        

    public readonly struct r12q : IRegOp64<r12q,N12>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r12q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R12q;
    }                    

    public readonly struct r13q : IRegOp64<r13q,N13>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r13q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R13q;
    }                        

    public readonly struct r14q : IRegOp64<r14q,N14>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r14q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R14q;
    }                        

    public readonly struct r15q : IRegOp64<r15q,N15>
    {
        public Fixed64 Value  {get;}

        [MethodImpl(Inline)]
        public r15q(Fixed64 value)
        {
            Value = value;
        }

        public K Kind => K.R15q;
    } 
}