//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{

    using K = Z0.Asm.Data.RegisterKind;
    using static Z0.Asm.Data.RegisterKind;

    partial class Registers
    {
        public readonly struct XMM0 : IXmmReg<XMM0,N0>
        {
            public const uint Width = IXmmReg.Width;
            
            public const int Index = 0;

            

            public K Kind => K.XMM0;
        }

        public readonly struct XMM1 : IXmmReg<XMM1,N1>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 1;
        
            public K Kind => K.XMM1;
        }

        public readonly struct XMM2 : IXmmReg<XMM2,N2>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 2;

            

            public K Kind => K.XMM2;
        }

        public readonly struct XMM3 : IXmmReg<XMM3,N3>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 3;

            

            public K Kind => K.XMM3;
        }

        public readonly struct XMM4 : IXmmReg<XMM4,N4>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 4;

            
            
            public K Kind => K.XMM4;
        }

        public readonly struct XMM5 : IXmmReg<XMM5,N5>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 5;

            

            public K Kind => K.XMM5;
        }

        public readonly struct XMM6 : IXmmReg<XMM6,N6>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 6;

            

            public K Kind => K.XMM6;
        }

        public readonly struct XMM7 : IXmmReg<XMM7,N7>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 7;

            

            public K Kind => K.XMM7;
        }

        public readonly struct XMM8 : IXmmReg<XMM8,N8>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 8;

            

            public K Kind => K.XMM8;
        }

        public readonly struct XMM9 : IXmmReg<XMM9,N9>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 9;

            

            public K Kind => K.XMM9;
        }

        public readonly struct XMM10 : IXmmReg<XMM10,N10>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 10;

            

            public K Kind => K.XMM10;
        }

        public readonly struct XMM11 : IXmmReg<XMM11,N11>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 11;

            

            public K Kind => K.XMM11;
        }

        public readonly struct XMM12 : IXmmReg<XMM12,N12>
        {
            

            public const uint Width = IXmmReg.Width;

            public const int Index = 12;

            public K Kind => K.XMM12;
        }


        public readonly struct XMM13 : IXmmReg<XMM13,N13>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 13;

            

            public K Kind => K.XMM13;
        }

        public readonly struct XMM14 : IXmmReg<XMM14,N14>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 14;

            
            
            public K Kind => K.XMM14;
        }

        public readonly struct XMM : IXmmReg<XMM,N15>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 15;

            

            public K Kind => XMM15;
        }

        public readonly struct xmm16 : IXmmReg<xmm16,N16>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 16;

            

            public K Kind => XMM16;
        }

        public readonly struct xmm17 : IXmmReg<xmm17,N17>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 17;

            

            public K Kind => XMM17;
        }

        public readonly struct xmm18 : IXmmReg<xmm18,N18>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 18;

            

            public K Kind => XMM18;
        }

        public readonly struct xmm19 : IXmmReg<xmm19,N19>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 19;

            

            public K Kind => XMM19;
        }

        public readonly struct xmm20 : IXmmReg<xmm20,N20>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 20;

            

            public K Kind => XMM20;
        }

        public readonly struct xmm21 : IXmmReg<xmm21,N21>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 21;

            

            public K Kind => XMM21;
        }

        public readonly struct xmm22 : IXmmReg<xmm22,N22>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 22;

            

            public K Kind => XMM22;
        }


        public readonly struct xmm23 : IXmmReg<xmm23,N23>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 23;

            

            public K Kind => XMM23;
        }

        public readonly struct xmm24 : IXmmReg<xmm24,N24>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 24;

            
            
            public K Kind => XMM24;
        }

        public readonly struct xmm25 : IXmmReg<xmm25,N25>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 25;

            

            public K Kind => XMM25;
        }

        public readonly struct xmm26 : IXmmReg<xmm26,N26>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 26;

            

            public K Kind => XMM26;
        }

        public readonly struct xmm27 : IXmmReg<xmm27,N27>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 27;

            

            public K Kind => XMM27;
        }

        public readonly struct xmm28 : IXmmReg<xmm28,N28>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 28;

            

            public K Kind => XMM28;
        }

        public readonly struct xmm29 : IXmmReg<xmm29,N29>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 29;

            

            public K Kind => XMM29;
        }

        public readonly struct xmm30 : IXmmReg<xmm30,N30>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 30;

            

            public K Kind => XMM30;
        }

        public readonly struct XMM31 : IXmmReg<XMM31,N31>
        {
            public const uint Width = IXmmReg.Width;

            public const int Index = 31;

            

            public K Kind => K.XMM31;
        }
    }
}