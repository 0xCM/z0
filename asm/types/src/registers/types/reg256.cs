//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;
    using static RegisterKind;

    using S = Fixed256V;
    using K = RegisterKind;

    partial class Registers
    {
        public readonly struct Reg256 : ymm<Fixed256V>
        {
            public const uint Width = ymm.Width;

            public Fixed256V State {get;}
        }

        public readonly struct Reg256<N> : ymm<Reg256<N>, N>
            where N : unmanaged, ITypeNat
        {
            public const uint Width = ymm.Width;

            public Fixed256V State {get;}
        }

        public readonly struct ymm0 : ymm<ymm0,N0>
        {
            public const uint Width = ymm.Width;
            
            public const int Index = 0;

            public S State {get;}

            public K Kind => YMM0;
        }

        public readonly struct ymm1 : ymm<ymm1,N1>
        {
            public const uint Width = ymm.Width;

            public const int Index = 1;

            public S State {get;}

            public K Kind => YMM1;
        }

        public readonly struct ymm2 : ymm<ymm2,N2>
        {
            public const uint Width = ymm.Width;

            public const int Index = 2;

            public S State {get;}

            public K Kind => YMM2;
        }

        public readonly struct ymm3 : ymm<ymm3,N3>
        {
            public const uint Width = ymm.Width;

            public const int Index = 3;

            public S State {get;}

            public K Kind => YMM3;
        }

        public readonly struct ymm4 : ymm<ymm4,N4>
        {
            public const uint Width = ymm.Width;

            public const int Index = 4;

            public S State {get;}
            
            public K Kind => YMM4;
        }

        public readonly struct ymm5 : ymm<ymm5,N5>
        {
            public const uint Width = ymm.Width;

            public const int Index = 5;

            public S State {get;}

            public K Kind => YMM5;
        }

        public readonly struct ymm6 : ymm<ymm6,N6>
        {
            public const uint Width = ymm.Width;

            public const int Index = 6;

            public S State {get;}

            public K Kind => YMM6;
        }

        public readonly struct ymm7 : ymm<ymm7,N7>
        {
            public const uint Width = ymm.Width;

            public const int Index = 7;

            public S State {get;}

            public K Kind => YMM7;
        }

        public readonly struct ymm8 : ymm<ymm8,N8>
        {
            public const uint Width = ymm.Width;

            public const int Index = 8;

            public S State {get;}

            public K Kind => YMM8;
        }

        public readonly struct ymm9 : ymm<ymm9,N9>
        {
            public const uint Width = ymm.Width;

            public const int Index = 9;

            public S State {get;}

            public K Kind => YMM9;
        }

        public readonly struct ymm10 : ymm<ymm10,N10>
        {
            public const uint Width = ymm.Width;

            public const int Index = 10;

            public S State {get;}

            public K Kind => YMM10;
        }

        public readonly struct ymm11 : ymm<ymm11,N11>
        {
            public const uint Width = ymm.Width;

            public const int Index = 11;

            public S State {get;}

            public K Kind => YMM11;
        }

        public readonly struct ymm12 : ymm<ymm12,N12>
        {
            public S State {get;}

            public const uint Width = ymm.Width;

            public const int Index = 12;

            public K Kind => YMM12;
        }


        public readonly struct ymm13 : ymm<ymm13,N13>
        {
            public const uint Width = ymm.Width;

            public const int Index = 13;

            public S State {get;}

            public K Kind => YMM13;
        }

        public readonly struct ymm14 : ymm<ymm14,N14>
        {
            public const uint Width = ymm.Width;

            public const int Index = 14;

            public S State {get;}
            
            public K Kind => YMM14;
        }

        public readonly struct ymm15 : ymm<ymm15,N15>
        {
            public const uint Width = ymm.Width;

            public const int Index = 15;

            public S State {get;}

            public K Kind => YMM15;
        }

        public readonly struct ymm16 : ymm<ymm16,N16>
        {
            public const uint Width = ymm.Width;

            public const int Index = 16;

            public S State {get;}

            public K Kind => YMM16;
        }

        public readonly struct ymm17 : ymm<ymm17,N17>
        {
            public const uint Width = ymm.Width;

            public const int Index = 17;

            public S State {get;}

            public K Kind => YMM17;
        }

        public readonly struct ymm18 : ymm<ymm18,N18>
        {
            public const uint Width = ymm.Width;

            public const int Index = 18;

            public S State {get;}

            public K Kind => YMM18;
        }

        public readonly struct ymm19 : ymm<ymm19,N19>
        {
            public const uint Width = ymm.Width;

            public const int Index = 19;

            public S State {get;}

            public K Kind => YMM19;
        }

        public readonly struct ymm20 : ymm<ymm20,N20>
        {
            public const uint Width = ymm.Width;

            public const int Index = 20;

            public S State {get;}

            public K Kind => YMM20;
        }

        public readonly struct ymm21 : ymm<ymm21,N21>
        {
            public const uint Width = ymm.Width;

            public const int Index = 21;

            public S State {get;}

            public K Kind => YMM21;
        }

        public readonly struct ymm22 : ymm<ymm22,N22>
        {
            public const uint Width = ymm.Width;

            public const int Index = 22;

            public S State {get;}

            public K Kind => YMM22;
        }


        public readonly struct ymm23 : ymm<ymm23,N23>
        {
            public const uint Width = ymm.Width;

            public const int Index = 23;

            public S State {get;}

            public K Kind => YMM23;
        }

        public readonly struct ymm24 : ymm<ymm24,N24>
        {
            public const uint Width = ymm.Width;

            public const int Index = 24;

            public S State {get;}
            
            public K Kind => YMM24;
        }

        public readonly struct ymm25 : ymm<ymm25,N25>
        {
            public const uint Width = ymm.Width;

            public const int Index = 25;

            public S State {get;}

            public K Kind => YMM25;
        }

        public readonly struct ymm26 : ymm<ymm26,N26>
        {
            public const uint Width = ymm.Width;

            public const int Index = 26;

            public S State {get;}

            public K Kind => YMM26;
        }

        public readonly struct ymm27 : ymm<ymm27,N27>
        {
            public const uint Width = ymm.Width;

            public const int Index = 27;

            public S State {get;}

            public K Kind => YMM27;
        }

        public readonly struct ymm28 : ymm<ymm28,N28>
        {
            public const uint Width = ymm.Width;

            public const int Index = 28;

            public S State {get;}

            public K Kind => YMM28;
        }

        public readonly struct ymm29 : ymm<ymm29,N29>
        {
            public const uint Width = ymm.Width;

            public const int Index = 29;

            public S State {get;}

            public K Kind => YMM29;
        }

        public readonly struct ymm30 : ymm<ymm30,N30>
        {
            public const uint Width = ymm.Width;

            public const int Index = 30;

            public S State {get;}

            public K Kind => YMM30;
        }

        public readonly struct ymm31 : ymm<ymm31,N31>
        {
            public const uint Width = ymm.Width;

            public const int Index = 31;

            public S State {get;}

            public K Kind => YMM31;
        }
    }
}