//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;
    using static RegisterKind;

    using S = Fixed128V;
    using K = RegisterKind;

    partial class Registers
    {

        public readonly struct xmm0 : xmm<xmm0,N0>
        {
            public const uint Width = xmm.Width;
            
            public const int Index = 0;

            public S State {get;}

            public K Kind => XMM0;
        }

        public readonly struct xmm1 : xmm<xmm1,N1>
        {
            public const uint Width = xmm.Width;

            public const int Index = 1;

            public S State {get;}

            public K Kind => XMM1;
        }

        public readonly struct xmm2 : xmm<xmm2,N2>
        {
            public const uint Width = xmm.Width;

            public const int Index = 2;

            public S State {get;}

            public K Kind => XMM2;
        }

        public readonly struct xmm3 : xmm<xmm3,N3>
        {
            public const uint Width = xmm.Width;

            public const int Index = 3;

            public S State {get;}

            public K Kind => XMM3;
        }

        public readonly struct xmm4 : xmm<xmm4,N4>
        {
            public const uint Width = xmm.Width;

            public const int Index = 4;

            public S State {get;}
            
            public K Kind => XMM4;
        }

        public readonly struct xmm5 : xmm<xmm5,N5>
        {
            public const uint Width = xmm.Width;

            public const int Index = 5;

            public S State {get;}

            public K Kind => XMM5;
        }

        public readonly struct xmm6 : xmm<xmm6,N6>
        {
            public const uint Width = xmm.Width;

            public const int Index = 6;

            public S State {get;}

            public K Kind => XMM6;
        }

        public readonly struct xmm7 : xmm<xmm7,N7>
        {
            public const uint Width = xmm.Width;

            public const int Index = 7;

            public S State {get;}

            public K Kind => XMM7;
        }

        public readonly struct xmm8 : xmm<xmm8,N8>
        {
            public const uint Width = xmm.Width;

            public const int Index = 8;

            public S State {get;}

            public K Kind => XMM8;
        }

        public readonly struct xmm9 : xmm<xmm9,N9>
        {
            public const uint Width = xmm.Width;

            public const int Index = 9;

            public S State {get;}

            public K Kind => XMM9;
        }

        public readonly struct xmm10 : xmm<xmm10,N10>
        {
            public const uint Width = xmm.Width;

            public const int Index = 10;

            public S State {get;}

            public K Kind => XMM10;
        }

        public readonly struct xmm11 : xmm<xmm11,N11>
        {
            public const uint Width = xmm.Width;

            public const int Index = 11;

            public S State {get;}

            public K Kind => XMM11;
        }

        public readonly struct xmm12 : xmm<xmm12,N12>
        {
            public S State {get;}

            public const uint Width = xmm.Width;

            public const int Index = 12;

            public K Kind => XMM12;
        }


        public readonly struct xmm13 : xmm<xmm13,N13>
        {
            public const uint Width = xmm.Width;

            public const int Index = 13;

            public S State {get;}

            public K Kind => XMM13;
        }

        public readonly struct xmm14 : xmm<xmm14,N14>
        {
            public const uint Width = xmm.Width;

            public const int Index = 14;

            public S State {get;}
            
            public K Kind => XMM14;
        }

        public readonly struct xmm15 : xmm<xmm15,N15>
        {
            public const uint Width = xmm.Width;

            public const int Index = 15;

            public S State {get;}

            public K Kind => XMM15;
        }

        public readonly struct xmm16 : xmm<xmm16,N16>
        {
            public const uint Width = xmm.Width;

            public const int Index = 16;

            public S State {get;}

            public K Kind => XMM16;
        }

        public readonly struct xmm17 : xmm<xmm17,N17>
        {
            public const uint Width = xmm.Width;

            public const int Index = 17;

            public S State {get;}

            public K Kind => XMM17;
        }

        public readonly struct xmm18 : xmm<xmm18,N18>
        {
            public const uint Width = xmm.Width;

            public const int Index = 18;

            public S State {get;}

            public K Kind => XMM18;
        }

        public readonly struct xmm19 : xmm<xmm19,N19>
        {
            public const uint Width = xmm.Width;

            public const int Index = 19;

            public S State {get;}

            public K Kind => XMM19;
        }

        public readonly struct xmm20 : xmm<xmm20,N20>
        {
            public const uint Width = xmm.Width;

            public const int Index = 20;

            public S State {get;}

            public K Kind => XMM20;
        }

        public readonly struct xmm21 : xmm<xmm21,N21>
        {
            public const uint Width = xmm.Width;

            public const int Index = 21;

            public S State {get;}

            public K Kind => XMM21;
        }

        public readonly struct xmm22 : xmm<xmm22,N22>
        {
            public const uint Width = xmm.Width;

            public const int Index = 22;

            public S State {get;}

            public K Kind => XMM22;
        }


        public readonly struct xmm23 : xmm<xmm23,N23>
        {
            public const uint Width = xmm.Width;

            public const int Index = 23;

            public S State {get;}

            public K Kind => XMM23;
        }

        public readonly struct xmm24 : xmm<xmm24,N24>
        {
            public const uint Width = xmm.Width;

            public const int Index = 24;

            public S State {get;}
            
            public K Kind => XMM24;
        }

        public readonly struct xmm25 : xmm<xmm25,N25>
        {
            public const uint Width = xmm.Width;

            public const int Index = 25;

            public S State {get;}

            public K Kind => XMM25;
        }

        public readonly struct xmm26 : xmm<xmm26,N26>
        {
            public const uint Width = xmm.Width;

            public const int Index = 26;

            public S State {get;}

            public K Kind => XMM26;
        }

        public readonly struct xmm27 : xmm<xmm27,N27>
        {
            public const uint Width = xmm.Width;

            public const int Index = 27;

            public S State {get;}

            public K Kind => XMM27;
        }

        public readonly struct xmm28 : xmm<xmm28,N28>
        {
            public const uint Width = xmm.Width;

            public const int Index = 28;

            public S State {get;}

            public K Kind => XMM28;
        }

        public readonly struct xmm29 : xmm<xmm29,N29>
        {
            public const uint Width = xmm.Width;

            public const int Index = 29;

            public S State {get;}

            public K Kind => XMM29;
        }

        public readonly struct xmm30 : xmm<xmm30,N30>
        {
            public const uint Width = xmm.Width;

            public const int Index = 30;

            public S State {get;}

            public K Kind => XMM30;
        }

        public readonly struct xmm31 : xmm<xmm31,N31>
        {
            public const uint Width = xmm.Width;

            public const int Index = 31;

            public S State {get;}

            public K Kind => XMM31;
        }
    }
}