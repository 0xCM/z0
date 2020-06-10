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

        [MethodImpl(Inline)]
        public cl(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.CL;
    }    

    public readonly struct dl : IRegOp8<dl,N2>
    {            
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public dl(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.DL;
    }    

    public readonly struct bl : IRegOp8<bl,N3>
    {        

        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public bl(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.BL;
    }    

    public readonly struct sil : IRegOp8<sil,N4>
    {            
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public sil(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.SIL;
    }    

    public readonly struct dil : IRegOp8<dil,N5>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public dil(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.DIL;
    }        

    public readonly struct spl : IRegOp8<spl,N6>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public spl(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.SPL;
    }            

    public readonly struct bpl : IRegOp8<bpl,N7>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public bpl(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.BPL;
    }                

    public readonly struct r8b : IRegOp8<r8b,N8>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r8b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R8L;
    }                    

    public readonly struct r9b : IRegOp8<r9b,N9>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r9b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R9L;
    }                        

    public readonly struct r10b : IRegOp8<r10b,N10>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r10b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R10L;
    }                        

    public readonly struct r11b : IRegOp8<r11b,N11>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r11b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R11L;
    }                        

    public readonly struct r12b : IRegOp8<r12b,N12>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r12b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R12L;
    }                    

    public readonly struct r13b : IRegOp8<r13b,N13>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r13b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R13L;
    }                        

    public readonly struct r14b : IRegOp8<r14b,N14>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r14b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R14L;
    }                        

    public readonly struct r15b : IRegOp8<r15b,N15>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public r15b(Fixed8 value)
        {
            Value = value;
        }

        public K Kind => K.R15L;
    }
 
}