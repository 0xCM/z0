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

    public readonly struct ymm0 : IYmmRegOp<ymm0,N0>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm0(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM0;
    }

    public readonly struct ymm1 : IYmmRegOp<ymm1,N1>
    {
        public Fixed256 Content {get;}


        [MethodImpl(Inline)]
        public ymm1(Fixed256 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM1;
    }

    public readonly struct ymm2 : IYmmRegOp<ymm2,N2>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm2(Fixed256 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM2;
    }

    public readonly struct ymm3 : IYmmRegOp<ymm3,N3>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm3(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM3;
    }

    public readonly struct ymm4 : IYmmRegOp<ymm4,N4>
    {                        
        public Fixed256 Content {get;}


        [MethodImpl(Inline)]
        public ymm4(Fixed256 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM4;
    }

    public readonly struct ymm5 : IYmmRegOp<ymm5,N5>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm5(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM5;
    }

    public readonly struct ymm6 : IYmmRegOp<ymm6,N6>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm6(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM6;
    }

    public readonly struct ymm7 : IYmmRegOp<ymm7,N7>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm7(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM7;
    }

    public readonly struct ymm8 : IYmmRegOp<ymm8,N8>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm8(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM8;
    }

    public readonly struct ymm9 : IYmmRegOp<ymm9,N9>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm9(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM9;
    }

    public readonly struct ymm10 : IYmmRegOp<ymm10,N10>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm10(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM10;
    }

    public readonly struct ymm11 : IYmmRegOp<ymm11,N11>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm11(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM11;
    }

    public readonly struct ymm12 : IYmmRegOp<ymm12,N12>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm12(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM12;
    }

    public readonly struct ymm13 : IYmmRegOp<ymm13,N13>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm13(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM13;
    }

    public readonly struct ymm14 : IYmmRegOp<ymm14,N14>
    {            
        public Fixed256 Content {get;}
        
        [MethodImpl(Inline)]
        public ymm14(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM14;
    }

    public readonly struct ymm15 : IYmmRegOp<ymm15,N15>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm15(Fixed256 value)
        {
            Content = value;
        }
        public K Kind => K.XMM15;
    }

    public readonly struct ymm16 : IYmmRegOp<ymm16,N16>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm16(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM16;

    }

    public readonly struct ymm17 : IYmmRegOp<ymm17,N17>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm17(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM17;
    }

    public readonly struct ymm18 : IYmmRegOp<ymm18,N18>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm18(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM18;
    }

    public readonly struct ymm19 : IYmmRegOp<ymm19,N19>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm19(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM19;
    }

    public readonly struct ymm20 : IYmmRegOp<ymm20,N20>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm20(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM20;
    }

    public readonly struct ymm21 : IYmmRegOp<ymm21,N21>
    {               
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm21(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM21;
    }

    public readonly struct ymm22 : IYmmRegOp<ymm22,N22>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm22(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM22;
    }

    public readonly struct ymm23 : IYmmRegOp<ymm23,N23>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm23(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM23;
    }

    public readonly struct ymm24 : IYmmRegOp<ymm24,N24>
    {            
        public Fixed256 Content {get;}


        [MethodImpl(Inline)]
        public ymm24(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM24;
    }

    public readonly struct ymm25 : IYmmRegOp<ymm25,N25>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm25(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM25;
    }

    public readonly struct ymm26 : IYmmRegOp<ymm26,N26>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm26(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM26;
    }

    public readonly struct ymm27 : IYmmRegOp<ymm27,N27>
    {            
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm27(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM27;
    }

    public readonly struct ymm28 : IYmmRegOp<ymm28,N28>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm28(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM28;
    }

    public readonly struct ymm29 : IYmmRegOp<ymm29,N29>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm29(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM29;
    }

    public readonly struct ymm30 : IYmmRegOp<ymm30,N30>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm30(Fixed256 value)
        {
            Content = value;
        }

        public K Kind => K.XMM30;
    }

    public readonly struct ymm31 : IYmmRegOp<ymm31,N31>
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