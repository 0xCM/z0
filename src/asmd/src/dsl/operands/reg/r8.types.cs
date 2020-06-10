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
        
    public readonly struct al : IRegOp8<al,N0>
    {            
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public al(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.AL;
    }

    public readonly struct cl : IRegOp8<cl,N1>
    {        
        public Fixed8 Value {get;}

        public K Kind => K.CL;
    }    

    public readonly struct dl : IRegOp8<dl,N2>
    {            
        public Fixed8 Value {get;}

        public K Kind => K.DL;
    }    

    public readonly struct bl : IRegOp8<bl,N3>
    {        
        public Fixed8 Value {get;}
        public K Kind => K.BL;
    }    

    public readonly struct sil : IRegOp8<sil,N4>
    {            
        public Fixed8 Value {get;}
        public K Kind => K.SIL;
    }    

    public readonly struct dil : IRegOp8<dil,N5>
    {
        public Fixed8 Value {get;}

        public K Kind => K.DIL;
    }        

    public readonly struct spl : IRegOp8<spl,N6>
    {
        public Fixed8 Value {get;}

        public K Kind => K.SPL;
    }            

    public readonly struct bpl : IRegOp8<bpl,N7>
    {
        public Fixed8 Value {get;}

        public K Kind => K.BPL;
    }                

    public readonly struct r8B : IRegOp8<r8B,N8>
    {
        public Fixed8 Value {get;}

        public K Kind => K.R8L;
    }                    

    public readonly struct r9B : IRegOp8<r9B,N9>
    {
        public Fixed8 Value {get;}

        public K Kind => K.R9L;
    }                        

    public readonly struct r10B : IRegOp8<r10B,N10>
    {
        public Fixed8 Value {get;}
        public K Kind => K.R10L;
    }                        

    public readonly struct r11B : IRegOp8<r11B,N11>
    {
        public Fixed8 Value {get;}

        public K Kind => K.R11L;
    }                        

    public readonly struct r12B : IRegOp8<r12B,N12>
    {
        public Fixed8 Value {get;}

        public K Kind => K.R12L;
    }                    

    public readonly struct r13b : IRegOp8<r13b,N13>
    {
        public Fixed8 Value {get;}
        public K Kind => K.R13L;
    }                        

    public readonly struct r14b : IRegOp8<r14b,N14>
    {
        public Fixed8 Value {get;}

        public K Kind => K.R14L;
    }                        

    public readonly struct r15b : IRegOp8<r15b,N15>
    {
        public Fixed8 Value {get;}

        public K Kind => K.R15L;
    }
 
}