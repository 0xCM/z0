//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    using static Z0.Asm.Data.RegisterKind;

    using K = Z0.Asm.Data.RegisterKind;

    partial class Registers
    {
        public readonly struct YMM0 : IYmmRegOp<YMM0,N0>
        {
            public const uint Width = IYmmRegOp.Width;
            
            public const int Index = 0;
        
            public K Kind => K.YMM0;
        }

        public readonly struct YMM1 : IYmmRegOp<YMM1,N1>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 1;
            
            public K Kind => K.YMM1;
        }

        public readonly struct YMM2 : IYmmRegOp<YMM2,N2>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 2;

            

            public K Kind => K.YMM2;
        }

        public readonly struct YMM3 : IYmmRegOp<YMM3,N3>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 3;

            

            public K Kind => K.YMM3;
        }

        public readonly struct YMM4 : IYmmRegOp<YMM4,N4>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 4;

            
            
            public K Kind => K.YMM4;
        }

        public readonly struct YMM5 : IYmmRegOp<YMM5,N5>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 5;

            

            public K Kind => K.YMM5;
        }

        public readonly struct YMM6 : IYmmRegOp<YMM6,N6>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 6;

            

            public K Kind => K.YMM6;
        }

        public readonly struct YMM7 : IYmmRegOp<YMM7,N7>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 7;

            

            public K Kind => K.YMM7;
        }

        public readonly struct YMM8 : IYmmRegOp<YMM8,N8>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 8;

            

            public K Kind => K.YMM8;
        }

        public readonly struct YMM9 : IYmmRegOp<YMM9,N9>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 9;

            

            public K Kind => K.YMM9;
        }

        public readonly struct YMM10 : IYmmRegOp<YMM10,N10>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 10;

            

            public K Kind => K.YMM10;
        }

        public readonly struct YMM11 : IYmmRegOp<YMM11,N11>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 11;

            

            public K Kind => K.YMM11;
        }

        public readonly struct YMM12 : IYmmRegOp<YMM12,N12>
        {
            

            public const uint Width = IYmmRegOp.Width;

            public const int Index = 12;

            public K Kind => K.YMM12;
        }


        public readonly struct YMM13 : IYmmRegOp<YMM13,N13>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 13;

            

            public K Kind => K.YMM13;
        }

        public readonly struct YMM14 : IYmmRegOp<YMM14,N14>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 14;

            
            
            public K Kind => K.YMM14;
        }

        public readonly struct YMM15 : IYmmRegOp<YMM15,N15>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 15;

            

            public K Kind => K.YMM15;
        }

        public readonly struct ymm16 : IYmmRegOp<ymm16,N16>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 16;

            

            public K Kind => YMM16;
        }

        public readonly struct ymm17 : IYmmRegOp<ymm17,N17>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 17;

            

            public K Kind => YMM17;
        }

        public readonly struct ymm18 : IYmmRegOp<ymm18,N18>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 18;

            

            public K Kind => YMM18;
        }

        public readonly struct ymm19 : IYmmRegOp<ymm19,N19>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 19;

            

            public K Kind => YMM19;
        }

        public readonly struct ymm20 : IYmmRegOp<ymm20,N20>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 20;

            

            public K Kind => YMM20;
        }

        public readonly struct ymm21 : IYmmRegOp<ymm21,N21>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 21;

            

            public K Kind => YMM21;
        }

        public readonly struct ymm22 : IYmmRegOp<ymm22,N22>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 22;

            

            public K Kind => YMM22;
        }


        public readonly struct ymm23 : IYmmRegOp<ymm23,N23>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 23;

            

            public K Kind => YMM23;
        }

        public readonly struct ymm24 : IYmmRegOp<ymm24,N24>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 24;

            
            
            public K Kind => YMM24;
        }

        public readonly struct ymm25 : IYmmRegOp<ymm25,N25>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 25;

            
            public K Kind => YMM25;
        }

        public readonly struct ymm26 : IYmmRegOp<ymm26,N26>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 26;

            
            public K Kind => YMM26;
        }

        public readonly struct ymm27 : IYmmRegOp<ymm27,N27>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 27;            

            public K Kind => YMM27;
        }

        public readonly struct ymm28 : IYmmRegOp<ymm28,N28>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 28;

            public K Kind => YMM28;
        }

        public readonly struct ymm29 : IYmmRegOp<ymm29,N29>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 29;

            
            public K Kind => YMM29;
        }

        public readonly struct ymm30 : IYmmRegOp<ymm30,N30>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 30;
            
            public K Kind => YMM30;
        }

        public readonly struct ymm31 : IYmmRegOp<ymm31,N31>
        {
            public const uint Width = IYmmRegOp.Width;

            public const int Index = 31;
        
            public K Kind => YMM31;
        }
    }
}