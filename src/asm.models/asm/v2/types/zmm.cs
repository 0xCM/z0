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

    public readonly struct zmm0 : IZmmOperand<zmm0,N0>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm0(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind
            => K.XMM0;
    }

    public readonly struct zmm1 : IZmmOperand<zmm1,N1>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm1(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind
            => K.XMM1;
    }

    public readonly struct zmm2 : IZmmOperand<zmm2,N2>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm2(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind
            => K.XMM2;
    }

    public readonly struct zmm3 : IZmmOperand<zmm3,N3>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm3(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM3;
    }

    public readonly struct zmm4 : IZmmOperand<zmm4,N4>
    {
        public FixedCell512 Content {get;}


        [MethodImpl(Inline)]
        public zmm4(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM4;
    }

    public readonly struct zmm5 : IZmmOperand<zmm5,N5>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm5(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM5;
    }

    public readonly struct zmm6 : IZmmOperand<zmm6,N6>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm6(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM6;
    }

    public readonly struct zmm7 : IZmmOperand<zmm7,N7>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm7(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM7;
    }

    public readonly struct zmm8 : IZmmOperand<zmm8,N8>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm8(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM8;
    }

    public readonly struct zmm9 : IZmmOperand<zmm9,N9>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm9(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM9;
    }

    public readonly struct zmm10 : IZmmOperand<zmm10,N10>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm10(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM10;
    }

    public readonly struct zmm11 : IZmmOperand<zmm11,N11>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm11(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM11;
    }

    public readonly struct zmm12 : IZmmOperand<zmm12,N12>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm12(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM12;
    }

    public readonly struct zmm13 : IZmmOperand<zmm13,N13>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm13(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM13;
    }

    public readonly struct zmm14 : IZmmOperand<zmm14,N14>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm14(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM14;
    }

    public readonly struct zmm15 : IZmmOperand<zmm15,N15>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm15(FixedCell512 value)
        {
            Content = value;
        }
        public K Kind => K.XMM15;
    }

    public readonly struct zmm16 : IZmmOperand<zmm16,N16>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm16(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM16;

    }

    public readonly struct zmm17 : IZmmOperand<zmm17,N17>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm17(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM17;
    }

    public readonly struct zmm18 : IZmmOperand<zmm18,N18>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm18(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM18;
    }

    public readonly struct zmm19 : IZmmOperand<zmm19,N19>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm19(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM19;
    }

    public readonly struct zmm20 : IZmmOperand<zmm20,N20>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm20(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM20;
    }

    public readonly struct zmm21 : IZmmOperand<zmm21,N21>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm21(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM21;
    }

    public readonly struct zmm22 : IZmmOperand<zmm22,N22>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm22(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM22;
    }

    public readonly struct zmm23 : IZmmOperand<zmm23,N23>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm23(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM23;
    }

    public readonly struct zmm24 : IZmmOperand<zmm24,N24>
    {
        public FixedCell512 Content {get;}


        [MethodImpl(Inline)]
        public zmm24(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM24;
    }

    public readonly struct zmm25 : IZmmOperand<zmm25,N25>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm25(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM25;
    }

    public readonly struct zmm26 : IZmmOperand<zmm26,N26>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm26(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM26;
    }

    public readonly struct zmm27 : IZmmOperand<zmm27,N27>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm27(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM27;
    }

    public readonly struct zmm28 : IZmmOperand<zmm28,N28>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm28(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM28;
    }

    public readonly struct zmm29 : IZmmOperand<zmm29,N29>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm29(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM29;
    }

    public readonly struct zmm30 : IZmmOperand<zmm30,N30>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm30(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM30;
    }

    public readonly struct zmm31 : IZmmOperand<zmm31,N31>
    {
        public FixedCell512 Content {get;}

        [MethodImpl(Inline)]
        public zmm31(FixedCell512 value)
        {
            Content = value;
        }

        public K Kind => K.XMM31;
    }
}