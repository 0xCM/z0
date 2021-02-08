//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = RegisterKind;
    using W = W128;
    using T = Cell128;

    partial struct AsmDsl
    {
        public struct xmm : IRegister<xmm,W,T>, IRegOp<T>
        {
            public byte Position {get;}

            public T Content {get;}

            public K RegKind {get;}


            [MethodImpl(Inline)]
            public xmm(byte pos, T data, K kind)
            {
                Position = pos;
                Content = data;
                RegKind = kind;
            }
        }

        public struct xmm0 : IRegister<xmm0,W,T>, IRegOp<T>
        {
            public const byte Index = 0;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm0(T value)
                => Data = value;

            public K RegKind => K.XMM0;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm0 src)
                => new Xmm(src.Content, K.XMM0);
        }

        public struct xmm1 : IRegister<xmm1,W,T>, IRegOp<T>
        {
            public const byte Index = 1;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm1(T value)
                => Data = value;

            public K RegKind => K.XMM1;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm1 src)
                => new Xmm(src.Content, K.XMM1);
        }

        public struct xmm2 : IRegister<xmm2,W,T>, IRegOp<T>
        {
            public const byte Index = 2;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm2(T value)
                => Data = value;

            public K RegKind => K.XMM2;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm2 src)
                => new Xmm(src.Content, K.XMM2);
        }

        public struct xmm3 : IRegister<xmm3,W,T>, IRegOp<T>
        {
            public const byte Index = 3;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm3(T value)
                => Data = value;

            public K RegKind => K.XMM3;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm3 src)
                => new Xmm(src.Content, K.XMM3);
        }

        public struct xmm4 : IRegister<xmm4,W,T>, IRegOp<T>
        {
            public const byte Index = 4;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm4(T value)
                => Data = value;

            public K RegKind => K.XMM4;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm4 src)
                => new Xmm(src.Content, K.XMM4);
        }

        public struct xmm5 : IRegister<xmm5,W,T>, IRegOp<T>
        {
            public const byte Index = 5;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm5(T value)
                => Data = value;

            public K RegKind => K.XMM5;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm5 src)
                => new Xmm(src.Content, K.XMM5);
        }

        public struct xmm6 : IRegister<xmm6,W,T>, IRegOp<T>
        {
            public const byte Index = 6;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm6(T value)
                => Data = value;

            public K RegKind => K.XMM6;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm6 src)
                => new Xmm(src.Content, K.XMM6);
        }

        public struct xmm7 : IRegister<xmm7,W,T>, IRegOp<T>
        {
            public const byte Index = 7;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm7(T value)
                => Data = value;

            public K RegKind => K.XMM7;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm7 src)
                => new Xmm(src.Content, K.XMM7);
        }

        public struct xmm8 : IRegister<xmm8,W,T>, IRegOp<T>
        {
            public const byte Index = 8;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm8(T value)
                => Data = value;

            public K RegKind => K.XMM8;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm8 src)
                => new Xmm(src.Content, K.XMM8);

        }

        public struct xmm9 : IRegister<xmm9,W,T>, IRegOp<T>
        {
            public const byte Index = 9;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm9(T value)
                => Data = value;

            public K RegKind => K.XMM9;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm9 src)
                => new Xmm(src.Content, K.XMM9);
        }

        public struct xmm10 : IRegister<xmm10,W,T>, IRegOp<T>
        {
            public const byte Index = 10;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm10(T value)
                => Data = value;

            public K RegKind => K.XMM10;

            [MethodImpl(Inline)]
            public static implicit operator Xmm(xmm10 src)
                => new Xmm(src.Content, K.XMM10);

        }

        public struct xmm11 : IRegister<xmm11,W,T>, IRegOp<T>
        {
            public const byte Index = 11;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm11(T value)
                => Data = value;

            public K RegKind => K.XMM11;
        }

        public struct xmm12 : IRegister<xmm12,W,T>, IRegOp<T>
        {
            public const byte Index = 12;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm12(T value)
                => Data = value;

            public K RegKind => K.XMM12;
        }

        public struct xmm13 : IXmmReg<xmm13,N13>, IRegOp<T>
        {
            public const byte Index = 13;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm13(T value)
                => Data = value;

            public K RegKind => K.XMM13;
        }

        public struct xmm14 : IXmmReg<xmm14,N14>, IRegOp<T>
        {
            public const byte Index = 14;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm14(T value)
                => Data = value;

            public K RegKind => K.XMM14;

            [MethodImpl(Inline)]
            public static implicit operator xmm14(Xmm src)
                => new xmm14(src.Content);
        }

        public struct xmm15 : IXmmReg<xmm15,N15>, IRegOp<T>
        {
            public const byte Index = 15;

            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm15(T value)
                => Data = value;

            public K RegKind => K.XMM15;

            [MethodImpl(Inline)]
            public static implicit operator xmm15(Xmm src)
                => new xmm15(src.Content);
        }

        public struct xmm16 : IXmmReg<xmm16,N16>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm16(T value)
                => Data = value;

            public K RegKind => K.XMM16;
        }

        public struct xmm17 : IXmmReg<xmm17,N17>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm17(T value)
                => Data = value;

            public K RegKind => K.XMM17;
        }

        public struct xmm18 : IXmmReg<xmm18,N18>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm18(T value)
                => Data = value;

            public K RegKind => K.XMM18;
        }

        public struct xmm19 : IXmmReg<xmm19,N19>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm19(T value)
                => Data = value;

            public K RegKind => K.XMM19;
        }

        public struct xmm20 : IXmmReg<xmm20,N20>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm20(T value)
                => Data = value;

            public K RegKind => K.XMM20;
        }

        public struct xmm21 : IXmmReg<xmm21,N21>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm21(T value)
                => Data = value;

            public K RegKind => K.XMM21;
        }

        public struct xmm22 : IXmmReg<xmm22,N22>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm22(T value)
                => Data = value;

            public K RegKind => K.XMM22;
        }

        public struct xmm23 : IXmmReg<xmm23,N23>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm23(T value)
                => Data = value;

            public K RegKind => K.XMM23;
        }

        public struct xmm24 : IXmmReg<xmm24,N24>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm24(T value)
                => Data = value;

            public K RegKind => K.XMM24;
        }

        public struct xmm25 : IXmmReg<xmm25,N25>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm25(T value)
                => Data = value;

            public K RegKind => K.XMM25;
        }

        public struct xmm26 : IXmmReg<xmm26,N26>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm26(T value)
                 => Data = value;

            public K RegKind => K.XMM26;
        }

        public struct xmm27 : IXmmReg<xmm27,N27>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm27(T value)
                => Data = value;

            public K RegKind => K.XMM27;
        }

        public struct xmm28 : IXmmReg<xmm28,N28>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm28(T value)
                => Data = value;

            public K RegKind => K.XMM28;
        }

        public struct xmm29 : IXmmReg<xmm29,N29>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm29(T value)
                => Data = value;

            public K RegKind => K.XMM29;
        }

        public struct xmm30 : IXmmReg<xmm30,N30>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm30(T value)
                => Data = value;

            public K RegKind => K.XMM30;
        }

        public struct xmm31 : IXmmReg<xmm31,N31>, IRegOp<T>
        {
            public T Data;

            public T Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public xmm31(T value)
                => Data = value;

            public K RegKind => K.XMM31;
        }
    }
}