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

    partial struct X86Registers
    {
        public struct xmm0 : IRegister<xmm0,W128,Cell128>
        {
            public const byte Index = 0;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm0(Cell128 value)
                => Data = value;

            public K Kind => K.XMM0;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm0 src)
                => new Xmm(src.Content, K.XMM0);
        }

        public struct xmm1 : IRegister<xmm1,W128,Cell128>
        {
            public const byte Index = 1;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm1(Cell128 value)
                => Data = value;

            public K Kind => K.XMM1;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm1 src)
                => new Xmm(src.Content, K.XMM1);
        }

        public struct xmm2 : IRegister<xmm2,W128,Cell128>
        {
            public const byte Index = 2;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm2(Cell128 value)
                => Data = value;

            public K Kind => K.XMM2;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm2 src)
                => new Xmm(src.Content, K.XMM2);
        }

        public struct xmm3 : IRegister<xmm3,W128,Cell128>
        {
            public const byte Index = 3;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm3(Cell128 value)
                => Data = value;

            public K Kind => K.XMM3;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm3 src)
                => new Xmm(src.Content, K.XMM3);
        }

        public struct xmm4 : IRegister<xmm4,W128,Cell128>
        {
            public const byte Index = 4;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm4(Cell128 value)
                => Data = value;

            public K Kind => K.XMM4;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm4 src)
                => new Xmm(src.Content, K.XMM4);
        }

        public struct xmm5 : IRegister<xmm5,W128,Cell128>
        {
            public const byte Index = 5;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm5(Cell128 value)
                => Data = value;

            public K Kind => K.XMM5;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm5 src)
                => new Xmm(src.Content, K.XMM5);
        }

        public struct xmm6 : IRegister<xmm6,W128,Cell128>
        {
            public const byte Index = 6;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm6(Cell128 value)
                => Data = value;

            public K Kind => K.XMM6;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm6 src)
                => new Xmm(src.Content, K.XMM6);
        }

        public struct xmm7 : IRegister<xmm7,W128,Cell128>
        {
            public const byte Index = 7;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm7(Cell128 value)
                => Data = value;

            public K Kind => K.XMM7;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm7 src)
                => new Xmm(src.Content, K.XMM7);
        }

        public struct xmm8 : IRegister<xmm8,W128,Cell128>
        {
            public const byte Index = 8;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm8(Cell128 value)
                => Data = value;

            public K Kind => K.XMM8;
        }

        public struct xmm9 : IRegister<xmm9,W128,Cell128>
        {
            public const byte Index = 9;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm9(Cell128 value)
                => Data = value;

            public K Kind => K.XMM9;
        }

        public struct xmm10 : IRegister<xmm10,W128,Cell128>
        {
            public const byte Index = 10;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm10(Cell128 value)
                => Data = value;

            public K Kind => K.XMM10;
        }

        public struct xmm11 : IRegister<xmm11,W128,Cell128>
        {
            public const byte Index = 11;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm11(Cell128 value)
                => Data = value;

            public K Kind => K.XMM11;
        }

        public struct xmm12 : IXmmReg<xmm12,N12>
        {
            public const byte Index = 12;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm12(Cell128 value)
                => Data = value;

            public K Kind => K.XMM12;
        }

        public struct xmm13 : IXmmReg<xmm13,N13>
        {
            public const byte Index = 13;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm13(Cell128 value)
                => Data = value;

            public K Kind => K.XMM13;
        }

        public struct xmm14 : IXmmReg<xmm14,N14>
        {
            public const byte Index = 14;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm14(Cell128 value)
                => Data = value;

            public K Kind => K.XMM14;
        }

        public struct xmm15 : IXmmReg<xmm15,N15>
        {
            public const byte Index = 15;

            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm15(Cell128 value)
                => Data = value;

            public K Kind => K.XMM15;
        }

        public struct xmm16 : IXmmReg<xmm16,N16>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm16(Cell128 value)
                => Data = value;

            public K Kind => K.XMM16;
        }

        public struct xmm17 : IXmmReg<xmm17,N17>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm17(Cell128 value)
                => Data = value;

            public K Kind => K.XMM17;
        }

        public struct xmm18 : IXmmReg<xmm18,N18>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm18(Cell128 value)
                => Data = value;

            public K Kind => K.XMM18;
        }

        public struct xmm19 : IXmmReg<xmm19,N19>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm19(Cell128 value)
                => Data = value;

            public K Kind => K.XMM19;
        }

        public struct xmm20 : IXmmReg<xmm20,N20>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm20(Cell128 value)
                => Data = value;

            public K Kind => K.XMM20;
        }

        public struct xmm21 : IXmmReg<xmm21,N21>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm21(Cell128 value)
                => Data = value;

            public K Kind => K.XMM21;
        }

        public struct xmm22 : IXmmReg<xmm22,N22>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm22(Cell128 value)
                => Data = value;

            public K Kind => K.XMM22;
        }

        public struct xmm23 : IXmmReg<xmm23,N23>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm23(Cell128 value)
                => Data = value;

            public K Kind => K.XMM23;
        }

        public struct xmm24 : IXmmReg<xmm24,N24>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm24(Cell128 value)
                => Data = value;

            public K Kind => K.XMM24;
        }

        public struct xmm25 : IXmmReg<xmm25,N25>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm25(Cell128 value)
                => Data = value;

            public K Kind => K.XMM25;
        }

        public struct xmm26 : IXmmReg<xmm26,N26>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm26(Cell128 value)
                 => Data = value;

            public K Kind => K.XMM26;
        }

        public struct xmm27 : IXmmReg<xmm27,N27>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm27(Cell128 value)
                => Data = value;

            public K Kind => K.XMM27;
        }

        public struct xmm28 : IXmmReg<xmm28,N28>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm28(Cell128 value)
                => Data = value;

            public K Kind => K.XMM28;
        }

        public struct xmm29 : IXmmReg<xmm29,N29>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm29(Cell128 value)
                => Data = value;

            public K Kind => K.XMM29;
        }

        public struct xmm30 : IXmmReg<xmm30,N30>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm30(Cell128 value)
                => Data = value;

            public K Kind => K.XMM30;
        }

        public struct xmm31 : IXmmReg<xmm31,N31>
        {
            public Cell128 Data;

            public Cell128 Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm31(Cell128 value)
                => Data = value;

            public K Kind => K.XMM31;
        }
    }
}