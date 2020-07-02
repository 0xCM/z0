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

    public readonly struct xmm0 : IXmmOperand<xmm0,N0>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm0(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM0;
    }

    public readonly struct xmm1 : IXmmOperand<xmm1,N1>
    {
        public Fixed128 Content {get;}


        [MethodImpl(Inline)]
        public xmm1(Fixed128 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM1;
    }

    public readonly struct xmm2 : IXmmOperand<xmm2,N2>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm2(Fixed128 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM2;
    }

    public readonly struct xmm3 : IXmmOperand<xmm3,N3>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm3(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM3;
    }

    public readonly struct xmm4 : IXmmOperand<xmm4,N4>
    {                        
        public Fixed128 Content {get;}


        [MethodImpl(Inline)]
        public xmm4(Fixed128 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM4;
    }

    public readonly struct xmm5 : IXmmOperand<xmm5,N5>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm5(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM5;
    }

    public readonly struct xmm6 : IXmmOperand<xmm6,N6>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm6(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM6;
    }

    public readonly struct xmm7 : IXmmOperand<xmm7,N7>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm7(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM7;
    }

    public readonly struct xmm8 : IXmmOperand<xmm8,N8>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm8(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM8;
    }

    public readonly struct xmm9 : IXmmOperand<xmm9,N9>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm9(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM9;
    }

    public readonly struct xmm10 : IXmmOperand<xmm10,N10>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm10(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM10;
    }

    public readonly struct xmm11 : IXmmOperand<xmm11,N11>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm11(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM11;
    }

    public readonly struct xmm12 : IXmmOperand<xmm12,N12>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm12(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM12;
    }

    public readonly struct xmm13 : IXmmOperand<xmm13,N13>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm13(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM13;
    }

    public readonly struct xmm14 : IXmmOperand<xmm14,N14>
    {            
        public Fixed128 Content {get;}
        
        [MethodImpl(Inline)]
        public xmm14(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM14;
    }

    public readonly struct xmm15 : IXmmOperand<xmm15,N15>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm15(Fixed128 value)
        {
            Content = value;
        }
        public K Kind => K.XMM15;
    }

    public readonly struct xmm16 : IXmmOperand<xmm16,N16>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm16(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM16;

    }

    public readonly struct xmm17 : IXmmOperand<xmm17,N17>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm17(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM17;
    }

    public readonly struct xmm18 : IXmmOperand<xmm18,N18>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm18(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM18;
    }

    public readonly struct xmm19 : IXmmOperand<xmm19,N19>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm19(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM19;
    }

    public readonly struct xmm20 : IXmmOperand<xmm20,N20>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm20(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM20;
    }

    public readonly struct xmm21 : IXmmOperand<xmm21,N21>
    {               
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm21(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM21;
    }

    public readonly struct xmm22 : IXmmOperand<xmm22,N22>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm22(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM22;
    }

    public readonly struct xmm23 : IXmmOperand<xmm23,N23>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm23(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM23;
    }

    public readonly struct xmm24 : IXmmOperand<xmm24,N24>
    {            
        public Fixed128 Content {get;}


        [MethodImpl(Inline)]
        public xmm24(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM24;
    }

    public readonly struct xmm25 : IXmmOperand<xmm25,N25>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm25(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM25;
    }

    public readonly struct xmm26 : IXmmOperand<xmm26,N26>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm26(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM26;
    }

    public readonly struct xmm27 : IXmmOperand<xmm27,N27>
    {            
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm27(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM27;
    }

    public readonly struct xmm28 : IXmmOperand<xmm28,N28>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm28(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM28;
    }

    public readonly struct xmm29 : IXmmOperand<xmm29,N29>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm29(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM29;
    }

    public readonly struct xmm30 : IXmmOperand<xmm30,N30>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm30(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM30;
    }

    public readonly struct xmm31 : IXmmOperand<xmm31,N31>
    {       
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm31(Fixed128 value)
        {
            Content = value;
        }

        public K Kind => K.XMM31;
    } 
}