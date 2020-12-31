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

    partial struct XRegisters
    {

        public readonly struct ymm0 : IRegister<ymm0,W256,Cell256>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm0(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM0;
        }

        public readonly struct ymm1 : IRegister<ymm1,W256,Cell256>
        {
            public Cell256 Content {get;}


            [MethodImpl(Inline)]
            public ymm1(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM1;
        }

        public readonly struct ymm2 : IRegister<ymm2,W256,Cell256>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm2(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM2;
        }

        public readonly struct ymm3 : IRegister<ymm3,W256,Cell256>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm3(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM3;
        }

        public readonly struct ymm4 : IYmmReg<ymm4,N4>
        {
            public Cell256 Content {get;}


            [MethodImpl(Inline)]
            public ymm4(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM4;
        }

        public readonly struct ymm5 : IYmmReg<ymm5,N5>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm5(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM5;
        }

        public readonly struct ymm6 : IYmmReg<ymm6,N6>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm6(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM6;
        }

        public readonly struct ymm7 : IYmmReg<ymm7,N7>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm7(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM7;
        }

        public readonly struct ymm8 : IYmmReg<ymm8,N8>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm8(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM8;
        }

        public readonly struct ymm9 : IYmmReg<ymm9,N9>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm9(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM9;
        }

        public readonly struct ymm10 : IYmmReg<ymm10,N10>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm10(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM10;
        }

        public readonly struct ymm11 : IYmmReg<ymm11,N11>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm11(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM11;
        }

        public readonly struct ymm12 : IYmmReg<ymm12,N12>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm12(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM12;
        }

        public readonly struct ymm13 : IYmmReg<ymm13,N13>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm13(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM13;
        }

        public readonly struct ymm14 : IYmmReg<ymm14,N14>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm14(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM14;
        }

        public readonly struct ymm15 : IYmmReg<ymm15,N15>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm15(Cell256 value)
            {
                Content = value;
            }
            public K Kind => K.XMM15;
        }

        public readonly struct ymm16 : IYmmReg<ymm16,N16>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm16(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM16;

        }

        public readonly struct ymm17 : IYmmReg<ymm17,N17>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm17(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM17;
        }

        public readonly struct ymm18 : IYmmReg<ymm18,N18>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm18(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM18;
        }

        public readonly struct ymm19 : IYmmReg<ymm19,N19>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm19(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM19;
        }

        public readonly struct ymm20 : IYmmReg<ymm20,N20>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm20(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM20;
        }

        public readonly struct ymm21 : IYmmReg<ymm21,N21>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm21(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM21;
        }

        public readonly struct ymm22 : IYmmReg<ymm22,N22>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm22(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM22;
        }

        public readonly struct ymm23 : IYmmReg<ymm23,N23>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm23(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM23;
        }

        public readonly struct ymm24 : IYmmReg<ymm24,N24>
        {
            public Cell256 Content {get;}


            [MethodImpl(Inline)]
            public ymm24(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM24;
        }

        public readonly struct ymm25 : IYmmReg<ymm25,N25>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm25(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM25;
        }

        public readonly struct ymm26 : IYmmReg<ymm26,N26>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm26(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM26;
        }

        public readonly struct ymm27 : IYmmReg<ymm27,N27>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm27(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM27;
        }

        public readonly struct ymm28 : IYmmReg<ymm28,N28>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm28(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM28;
        }

        public readonly struct ymm29 : IYmmReg<ymm29,N29>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm29(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM29;
        }

        public readonly struct ymm30 : IYmmReg<ymm30,N30>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm30(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM30;
        }

        public readonly struct ymm31 : IYmmReg<ymm31,N31>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public ymm31(Cell256 value)
            {
                Content = value;
            }

            public K Kind => K.XMM31;
        }
    }
}