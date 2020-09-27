//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = RegisterKind;

    partial struct AsmRegisters
    {
        public readonly struct zmm0 : IZmmReg<zmm0,N0>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm0(Cell512 value)
            {
                Content = value;
            }

            public K Kind
                => K.XMM0;
        }

        public readonly struct zmm1 : IZmmReg<zmm1,N1>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm1(Cell512 value)
            {
                Content = value;
            }

            public K Kind
                => K.XMM1;
        }

        public readonly struct zmm2 : IZmmReg<zmm2,N2>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm2(Cell512 value)
            {
                Content = value;
            }

            public K Kind
                => K.XMM2;
        }

        public readonly struct zmm3 : IZmmReg<zmm3,N3>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm3(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM3;
        }

        public readonly struct zmm4 : IZmmReg<zmm4,N4>
        {
            public Cell512 Content {get;}


            [MethodImpl(Inline)]
            public zmm4(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM4;
        }

        public readonly struct zmm5 : IZmmReg<zmm5,N5>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm5(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM5;
        }

        public readonly struct zmm6 : IZmmReg<zmm6,N6>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm6(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM6;
        }

        public readonly struct zmm7 : IZmmReg<zmm7,N7>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm7(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM7;
        }

        public readonly struct zmm8 : IZmmReg<zmm8,N8>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm8(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM8;
        }

        public readonly struct zmm9 : IZmmReg<zmm9,N9>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm9(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM9;
        }

        public readonly struct zmm10 : IZmmReg<zmm10,N10>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm10(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM10;
        }

        public readonly struct zmm11 : IZmmReg<zmm11,N11>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm11(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM11;
        }

        public readonly struct zmm12 : IZmmReg<zmm12,N12>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm12(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM12;
        }

        public readonly struct zmm13 : IZmmReg<zmm13,N13>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm13(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM13;
        }

        public readonly struct zmm14 : IZmmReg<zmm14,N14>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm14(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM14;
        }

        public readonly struct zmm15 : IZmmReg<zmm15,N15>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm15(Cell512 value)
            {
                Content = value;
            }
            public K Kind => K.XMM15;
        }

        public readonly struct zmm16 : IZmmReg<zmm16,N16>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm16(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM16;

        }

        public readonly struct zmm17 : IZmmReg<zmm17,N17>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm17(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM17;
        }

        public readonly struct zmm18 : IZmmReg<zmm18,N18>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm18(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM18;
        }

        public readonly struct zmm19 : IZmmReg<zmm19,N19>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm19(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM19;
        }

        public readonly struct zmm20 : IZmmReg<zmm20,N20>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm20(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM20;
        }

        public readonly struct zmm21 : IZmmReg<zmm21,N21>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm21(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM21;
        }

        public readonly struct zmm22 : IZmmReg<zmm22,N22>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm22(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM22;
        }

        public readonly struct zmm23 : IZmmReg<zmm23,N23>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm23(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM23;
        }

        public readonly struct zmm24 : IZmmReg<zmm24,N24>
        {
            public Cell512 Content {get;}


            [MethodImpl(Inline)]
            public zmm24(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM24;
        }

        public readonly struct zmm25 : IZmmReg<zmm25,N25>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm25(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM25;
        }

        public readonly struct zmm26 : IZmmReg<zmm26,N26>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm26(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM26;
        }

        public readonly struct zmm27 : IZmmReg<zmm27,N27>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm27(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM27;
        }

        public readonly struct zmm28 : IZmmReg<zmm28,N28>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm28(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM28;
        }

        public readonly struct zmm29 : IZmmReg<zmm29,N29>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm29(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM29;
        }

        public readonly struct zmm30 : IZmmReg<zmm30,N30>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm30(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM30;
        }

        public readonly struct zmm31 : IZmmReg<zmm31,N31>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public zmm31(Cell512 value)
            {
                Content = value;
            }

            public K Kind => K.XMM31;
        }
    }
}