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

    public readonly struct ymm0 : IYmmRegOperand<ymm0,N0>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm0(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM0;
    }

    public readonly struct ymm1 : IYmmRegOperand<ymm1,N1>
    {
        public Fixed256 Content {get;}


        [MethodImpl(Inline)]
        public ymm1(Fixed256 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM1;
    }

    public readonly struct ymm2 : IYmmRegOperand<ymm2,N2>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm2(Fixed256 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM2;
    }

    public readonly struct ymm3 : IYmmRegOperand<ymm3,N3>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm3(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM3;
    }

    public readonly struct ymm4 : IYmmRegOperand<ymm4,N4>
    {                        
        public Fixed256 Content {get;}


        [MethodImpl(Inline)]
        public ymm4(Fixed256 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM4;
    }

    public readonly struct ymm5 : IYmmRegOperand<ymm5,N5>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm5(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM5;
    }

    public readonly struct ymm6 : IYmmRegOperand<ymm6,N6>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm6(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM6;
    }

    public readonly struct ymm7 : IYmmRegOperand<ymm7,N7>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm7(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM7;
    }

    public readonly struct ymm8 : IYmmRegOperand<ymm8,N8>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm8(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM8;
    }

    public readonly struct ymm9 : IYmmRegOperand<ymm9,N9>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm9(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM9;
    }

    public readonly struct ymm10 : IYmmRegOperand<ymm10,N10>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm10(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM10;
    }

    public readonly struct ymm11 : IYmmRegOperand<ymm11,N11>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm11(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM11;
    }

    public readonly struct ymm12 : IYmmRegOperand<ymm12,N12>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm12(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM12;
    }

    public readonly struct ymm13 : IYmmRegOperand<ymm13,N13>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm13(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM13;
    }

    public readonly struct ymm14 : IYmmRegOperand<ymm14,N14>
    {            
        public Fixed256 Content {get;}
        
        [MethodImpl(Inline)]
        public ymm14(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM14;
    }

    public readonly struct ymm15 : IYmmRegOperand<ymm15,N15>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm15(Fixed256 value)
        {
            Content = value;
        }
        public K Kind => K.XMM15;
    }

    public readonly struct ymm16 : IYmmRegOperand<ymm16,N16>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm16(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM16;

    }

    public readonly struct ymm17 : IYmmRegOperand<ymm17,N17>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm17(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM17;
    }

    public readonly struct ymm18 : IYmmRegOperand<ymm18,N18>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm18(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM18;
    }

    public readonly struct ymm19 : IYmmRegOperand<ymm19,N19>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm19(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM19;
    }

    public readonly struct ymm20 : IYmmRegOperand<ymm20,N20>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm20(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM20;
    }

    public readonly struct ymm21 : IYmmRegOperand<ymm21,N21>
    {               
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm21(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM21;
    }

    public readonly struct ymm22 : IYmmRegOperand<ymm22,N22>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm22(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM22;
    }

    public readonly struct ymm23 : IYmmRegOperand<ymm23,N23>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm23(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM23;
    }

    public readonly struct ymm24 : IYmmRegOperand<ymm24,N24>
    {            
        public Fixed256 Content {get;}


        [MethodImpl(Inline)]
        public ymm24(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM24;
    }

    public readonly struct ymm25 : IYmmRegOperand<ymm25,N25>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm25(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM25;
    }

    public readonly struct ymm26 : IYmmRegOperand<ymm26,N26>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm26(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM26;
    }

    public readonly struct ymm27 : IYmmRegOperand<ymm27,N27>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm27(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM27;
    }

    public readonly struct ymm28 : IYmmRegOperand<ymm28,N28>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm28(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM28;
    }

    public readonly struct ymm29 : IYmmRegOperand<ymm29,N29>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm29(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM29;
    }

    public readonly struct ymm30 : IYmmRegOperand<ymm30,N30>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm30(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM30;
    }

    public readonly struct ymm31 : IYmmRegOperand<ymm31,N31>
    {       
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm31(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM31;
    } 
}