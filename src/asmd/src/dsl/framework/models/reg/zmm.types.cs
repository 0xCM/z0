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

    public readonly struct zmm0 : IZmmRegOp<zmm0,N0>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm0(Fixed512 value)
        {
            Content = value;
        }

        public K Kind 
            => K.XMM0;
    }

    public readonly struct zmm1 : IZmmRegOp<zmm1,N1>
    {
        public Fixed512 Content {get;}


        [MethodImpl(Inline)]
        public zmm1(Fixed512 value)
        {
            Content = value;
        }
        
        public K Kind 
            => K.XMM1;
    }

    public readonly struct zmm2 : IZmmRegOp<zmm2,N2>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm2(Fixed512 value)
        {
            Content = value;
        }
        
        public K Kind 
            => K.XMM2;
    }

    public readonly struct zmm3 : IZmmRegOp<zmm3,N3>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm3(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM3;
    }

    public readonly struct zmm4 : IZmmRegOp<zmm4,N4>
    {                        
        public Fixed512 Content {get;}


        [MethodImpl(Inline)]
        public zmm4(Fixed512 value)
        {
            Content = value;
        }
        
        public K Kind => K.XMM4;
    }

    public readonly struct zmm5 : IZmmRegOp<zmm5,N5>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm5(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM5;
    }

    public readonly struct zmm6 : IZmmRegOp<zmm6,N6>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm6(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM6;
    }

    public readonly struct zmm7 : IZmmRegOp<zmm7,N7>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm7(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM7;
    }

    public readonly struct zmm8 : IZmmRegOp<zmm8,N8>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm8(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM8;
    }

    public readonly struct zmm9 : IZmmRegOp<zmm9,N9>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm9(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM9;
    }

    public readonly struct zmm10 : IZmmRegOp<zmm10,N10>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm10(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM10;
    }

    public readonly struct zmm11 : IZmmRegOp<zmm11,N11>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm11(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM11;
    }

    public readonly struct zmm12 : IZmmRegOp<zmm12,N12>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm12(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM12;
    }

    public readonly struct zmm13 : IZmmRegOp<zmm13,N13>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm13(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM13;
    }

    public readonly struct zmm14 : IZmmRegOp<zmm14,N14>
    {            
        public Fixed512 Content {get;}
        
        [MethodImpl(Inline)]
        public zmm14(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM14;
    }

    public readonly struct zmm15 : IZmmRegOp<zmm15,N15>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm15(Fixed512 value)
        {
            Content = value;
        }
        public K Kind => K.XMM15;
    }

    public readonly struct zmm16 : IZmmRegOp<zmm16,N16>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm16(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM16;

    }

    public readonly struct zmm17 : IZmmRegOp<zmm17,N17>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm17(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM17;
    }

    public readonly struct zmm18 : IZmmRegOp<zmm18,N18>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm18(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM18;
    }

    public readonly struct zmm19 : IZmmRegOp<zmm19,N19>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm19(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM19;
    }

    public readonly struct zmm20 : IZmmRegOp<zmm20,N20>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm20(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM20;
    }

    public readonly struct zmm21 : IZmmRegOp<zmm21,N21>
    {               
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm21(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM21;
    }

    public readonly struct zmm22 : IZmmRegOp<zmm22,N22>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm22(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM22;
    }

    public readonly struct zmm23 : IZmmRegOp<zmm23,N23>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm23(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM23;
    }

    public readonly struct zmm24 : IZmmRegOp<zmm24,N24>
    {            
        public Fixed512 Content {get;}


        [MethodImpl(Inline)]
        public zmm24(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM24;
    }

    public readonly struct zmm25 : IZmmRegOp<zmm25,N25>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm25(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM25;
    }

    public readonly struct zmm26 : IZmmRegOp<zmm26,N26>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm26(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM26;
    }

    public readonly struct zmm27 : IZmmRegOp<zmm27,N27>
    {            
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm27(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM27;
    }

    public readonly struct zmm28 : IZmmRegOp<zmm28,N28>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm28(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM28;
    }

    public readonly struct zmm29 : IZmmRegOp<zmm29,N29>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm29(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM29;
    }

    public readonly struct zmm30 : IZmmRegOp<zmm30,N30>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm30(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM30;
    }

    public readonly struct zmm31 : IZmmRegOp<zmm31,N31>
    {       
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public zmm31(Fixed512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM31;
    } 
}