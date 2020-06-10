//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    
    using static Konst;

    using K = RegisterKind;
    
    public readonly struct rax : IRegOp64<rax,N0>
    {        
        public Fixed64 Value  {get;}

        public K Kind => K.RAX;
    }

    public readonly struct rcx : IRegOp64<rcx,N1>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.RAX;
    }    

    public readonly struct rdx : IRegOp64<rdx,N2>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.RDX;
    }    

    public readonly struct rbx : IRegOp64<rbx,N3>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.RBX;
    }    

    public readonly struct rsi : IRegOp64<rsi,N4>
    {
        public Fixed64 Value  {get;}
        public K Kind => K.RSI;
    }    

    public readonly struct rdi : IRegOp64<rdi,N5>
    {
        public Fixed64 Value  {get;}
        public K Kind => K.RDI;
    }        

    public readonly struct rsp : IRegOp64<rsp,N6>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.RSP;
    }            

    public readonly struct rbp : IRegOp64<rbp,N7>
    {            
        public Fixed64 Value  {get;}

        public K Kind => K.RBP;
    }                

    public readonly struct R8q : IRegOp64<R8q,N8>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R8q;
    }                    

    public readonly struct R9q : IRegOp64<R9q,N9>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R9q;
    }                        

    public readonly struct R10q : IRegOp64<R10q,N10>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R10q;
    }                        

    public readonly struct R11q : IRegOp64<R11q,N11>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R11q;
    }                        

    public readonly struct R12q : IRegOp64<R12q,N12>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R12q;
    }                    

    public readonly struct R13q : IRegOp64<R13q,N13>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R13q;
    }                        

    public readonly struct R14q : IRegOp64<R14q,N14>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R14q;
    }                        

    public readonly struct R15q : IRegOp64<R15q,N15>
    {
        public Fixed64 Value  {get;}

        public K Kind => K.R15q;
    } 
}