//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using K = RegisterKind;

    public readonly struct xmm0 : IXmmRegOp<xmm0,N0>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm0(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM0;
    }

    public readonly struct xmm1 : IXmmRegOp<xmm1,N1>
    {
        public Fixed128 Value {get;}


        [MethodImpl(Inline)]
        public xmm1(Fixed128 value)
        {
            Value = value;
        }
        
        public K Kind => K.XMM1;
    }

    public readonly struct xmm2 : IXmmRegOp<xmm2,N2>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm2(Fixed128 value)
        {
            Value = value;
        }
        
        public K Kind => K.XMM2;
    }

    public readonly struct xmm3 : IXmmRegOp<xmm3,N3>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm3(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM3;
    }

    public readonly struct xmm4 : IXmmRegOp<xmm4,N4>
    {                        
        public Fixed128 Value {get;}


        [MethodImpl(Inline)]
        public xmm4(Fixed128 value)
        {
            Value = value;
        }
        
        public K Kind => K.XMM4;
    }

    public readonly struct xmm5 : IXmmRegOp<xmm5,N5>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm5(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM5;
    }

    public readonly struct xmm6 : IXmmRegOp<xmm6,N6>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm6(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM6;
    }

    public readonly struct xmm7 : IXmmRegOp<xmm7,N7>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm7(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM7;
    }

    public readonly struct xmm8 : IXmmRegOp<xmm8,N8>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm8(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM8;
    }

    public readonly struct xmm9 : IXmmRegOp<xmm9,N9>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm9(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM9;
    }

    public readonly struct xmm10 : IXmmRegOp<xmm10,N10>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm10(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM10;
    }

    public readonly struct xmm11 : IXmmRegOp<xmm11,N11>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm11(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM11;
    }

    public readonly struct xmm12 : IXmmRegOp<xmm12,N12>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm12(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM12;
    }

    public readonly struct xmm13 : IXmmRegOp<xmm13,N13>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm13(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM13;
    }

    public readonly struct xmm14 : IXmmRegOp<xmm14,N14>
    {            
        public Fixed128 Value {get;}
        
        [MethodImpl(Inline)]
        public xmm14(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM14;
    }

    public readonly struct xmm15 : IXmmRegOp<xmm15,N15>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm15(Fixed128 value)
        {
            Value = value;
        }
        public K Kind => K.XMM15;
    }

    public readonly struct xmm16 : IXmmRegOp<xmm16,N16>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm16(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM16;

    }

    public readonly struct xmm17 : IXmmRegOp<xmm17,N17>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm17(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM17;
    }

    public readonly struct xmm18 : IXmmRegOp<xmm18,N18>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm18(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM18;
    }

    public readonly struct xmm19 : IXmmRegOp<xmm19,N19>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm19(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM19;
    }

    public readonly struct xmm20 : IXmmRegOp<xmm20,N20>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm20(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM20;
    }

    public readonly struct xmm21 : IXmmRegOp<xmm21,N21>
    {               
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm21(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM21;
    }

    public readonly struct xmm22 : IXmmRegOp<xmm22,N22>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm22(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM22;
    }

    public readonly struct xmm23 : IXmmRegOp<xmm23,N23>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm23(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM23;
    }

    public readonly struct xmm24 : IXmmRegOp<xmm24,N24>
    {            
        public Fixed128 Value {get;}


        [MethodImpl(Inline)]
        public xmm24(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM24;
    }

    public readonly struct xmm25 : IXmmRegOp<xmm25,N25>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm25(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM25;
    }

    public readonly struct xmm26 : IXmmRegOp<xmm26,N26>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm26(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM26;
    }

    public readonly struct xmm27 : IXmmRegOp<xmm27,N27>
    {            
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm27(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM27;
    }

    public readonly struct xmm28 : IXmmRegOp<xmm28,N28>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm28(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM28;
    }

    public readonly struct xmm29 : IXmmRegOp<xmm29,N29>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm29(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM29;
    }

    public readonly struct xmm30 : IXmmRegOp<xmm30,N30>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm30(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM30;
    }

    public readonly struct xmm31 : IXmmRegOp<xmm31,N31>
    {       
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public xmm31(Fixed128 value)
        {
            Value = value;
        }

        public K Kind => K.XMM31;
    } 
}