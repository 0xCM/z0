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
        public readonly struct YMM0 : IYmmReg<YMM0,N0>
        {
            public const uint Width = IYmmReg.Width;
            
            public const int Index = 0;
        
            public K Kind => K.YMM0;
        }

        public readonly struct YMM1 : IYmmReg<YMM1,N1>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 1;
            
            public K Kind => K.YMM1;
        }

        public readonly struct YMM2 : IYmmReg<YMM2,N2>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 2;

            

            public K Kind => K.YMM2;
        }

        public readonly struct YMM3 : IYmmReg<YMM3,N3>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 3;

            

            public K Kind => K.YMM3;
        }

        public readonly struct YMM4 : IYmmReg<YMM4,N4>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 4;

            
            
            public K Kind => K.YMM4;
        }

        public readonly struct YMM5 : IYmmReg<YMM5,N5>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 5;

            

            public K Kind => K.YMM5;
        }

        public readonly struct YMM6 : IYmmReg<YMM6,N6>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 6;

            

            public K Kind => K.YMM6;
        }

        public readonly struct YMM7 : IYmmReg<YMM7,N7>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 7;

            

            public K Kind => K.YMM7;
        }

        public readonly struct YMM8 : IYmmReg<YMM8,N8>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 8;

            

            public K Kind => K.YMM8;
        }

        public readonly struct YMM9 : IYmmReg<YMM9,N9>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 9;

            

            public K Kind => K.YMM9;
        }

        public readonly struct YMM10 : IYmmReg<YMM10,N10>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 10;

            

            public K Kind => K.YMM10;
        }

        public readonly struct YMM11 : IYmmReg<YMM11,N11>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 11;

            

            public K Kind => K.YMM11;
        }

        public readonly struct YMM12 : IYmmReg<YMM12,N12>
        {
            

            public const uint Width = IYmmReg.Width;

            public const int Index = 12;

            public K Kind => K.YMM12;
        }


        public readonly struct YMM13 : IYmmReg<YMM13,N13>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 13;

            

            public K Kind => K.YMM13;
        }

        public readonly struct YMM14 : IYmmReg<YMM14,N14>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 14;

            
            
            public K Kind => K.YMM14;
        }

        public readonly struct YMM15 : IYmmReg<YMM15,N15>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 15;

            

            public K Kind => K.YMM15;
        }

        public readonly struct ymm16 : IYmmReg<ymm16,N16>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 16;

            

            public K Kind => YMM16;
        }

        public readonly struct ymm17 : IYmmReg<ymm17,N17>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 17;

            

            public K Kind => YMM17;
        }

        public readonly struct ymm18 : IYmmReg<ymm18,N18>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 18;

            

            public K Kind => YMM18;
        }

        public readonly struct ymm19 : IYmmReg<ymm19,N19>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 19;

            

            public K Kind => YMM19;
        }

        public readonly struct ymm20 : IYmmReg<ymm20,N20>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 20;

            

            public K Kind => YMM20;
        }

        public readonly struct ymm21 : IYmmReg<ymm21,N21>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 21;

            

            public K Kind => YMM21;
        }

        public readonly struct ymm22 : IYmmReg<ymm22,N22>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 22;

            

            public K Kind => YMM22;
        }


        public readonly struct ymm23 : IYmmReg<ymm23,N23>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 23;

            

            public K Kind => YMM23;
        }

        public readonly struct ymm24 : IYmmReg<ymm24,N24>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 24;

            
            
            public K Kind => YMM24;
        }

        public readonly struct ymm25 : IYmmReg<ymm25,N25>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 25;

            
            public K Kind => YMM25;
        }

        public readonly struct ymm26 : IYmmReg<ymm26,N26>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 26;

            
            public K Kind => YMM26;
        }

        public readonly struct ymm27 : IYmmReg<ymm27,N27>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 27;

            

            public K Kind => YMM27;
        }

        public readonly struct ymm28 : IYmmReg<ymm28,N28>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 28;

            

            public K Kind => YMM28;
        }

        public readonly struct ymm29 : IYmmReg<ymm29,N29>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 29;

            
            public K Kind => YMM29;
        }

        public readonly struct ymm30 : IYmmReg<ymm30,N30>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 30;
            
            public K Kind => YMM30;
        }

        public readonly struct ymm31 : IYmmReg<ymm31,N31>
        {
            public const uint Width = IYmmReg.Width;

            public const int Index = 31;
        
            public K Kind => YMM31;
        }
    }
}