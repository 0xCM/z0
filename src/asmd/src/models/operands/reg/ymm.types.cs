//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    using K = RegisterKind;

    public partial class Regs
    {
        public readonly struct ymm0 : IYmmRegOp<ymm0,N0>
        {                    
            public Fixed256 Value {get;}

            public K Kind => K.YMM0;
        }

        public readonly struct ymm1 : IYmmRegOp<ymm1,N1>
        {            
            public Fixed256 Value {get;}

            public K Kind => K.YMM1;
        }

        public readonly struct ymm2 : IYmmRegOp<ymm2,N2>
        {        
            public Fixed256 Value {get;}

            public K Kind => K.YMM2;
        }

        public readonly struct ymm3 : IYmmRegOp<ymm3,N3>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM3;
        }

        public readonly struct ymm4 : IYmmRegOp<ymm4,N4>
        {                        
            public Fixed256 Value {get;}

            public K Kind => K.YMM4;
        }

        public readonly struct ymm5 : IYmmRegOp<ymm5,N5>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM5;
        }

        public readonly struct ymm6 : IYmmRegOp<ymm6,N6>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM6;
        }

        public readonly struct ymm7 : IYmmRegOp<ymm7,N7>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM7;
        }

        public readonly struct ymm8 : IYmmRegOp<ymm8,N8>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM8;
        }

        public readonly struct ymm9 : IYmmRegOp<ymm9,N9>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM9;
        }

        public readonly struct ymm10 : IYmmRegOp<ymm10,N10>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM10;
        }

        public readonly struct ymm11 : IYmmRegOp<ymm11,N11>
        {            
            public Fixed256 Value {get;}

            public K Kind => K.YMM11;
        }

        public readonly struct ymm12 : IYmmRegOp<ymm12,N12>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM12;
        }


        public readonly struct ymm13 : IYmmRegOp<ymm13,N13>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM13;
        }

        public readonly struct ymm14 : IYmmRegOp<ymm14,N14>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM14;
        }

        public readonly struct ymm15 : IYmmRegOp<ymm15,N15>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM15;
        }

        public readonly struct YMM16 : IYmmRegOp<YMM16,N16>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM16;
        }

        public readonly struct YMM17 : IYmmRegOp<YMM17,N17>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM17;
        }

        public readonly struct YMM18 : IYmmRegOp<YMM18,N18>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM18;
        }

        public readonly struct YMM19 : IYmmRegOp<YMM19,N19>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM19;
        }

        public readonly struct YMM20 : IYmmRegOp<YMM20,N20>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM20;
        }

        public readonly struct YMM21 : IYmmRegOp<YMM21,N21>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM21;
        }

        public readonly struct YMM22 : IYmmRegOp<YMM22,N22>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM22;
        }

        public readonly struct YMM23 : IYmmRegOp<YMM23,N23>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM23;
        }

        public readonly struct YMM24 : IYmmRegOp<YMM24,N24>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM24;
        }

        public readonly struct YMM25 : IYmmRegOp<YMM25,N25>
        {            
            public Fixed256 Value {get;}
            public K Kind => K.YMM25;
        }

        public readonly struct YMM26 : IYmmRegOp<YMM26,N26>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM26;
        }

        public readonly struct YMM27 : IYmmRegOp<YMM27,N27>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM27;
        }

        public readonly struct YMM28 : IYmmRegOp<YMM28,N28>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM28;
        }

        public readonly struct YMM29 : IYmmRegOp<YMM29,N29>
        {           
            public Fixed256 Value {get;}

            public K Kind => K.YMM29;
        }

        public readonly struct YMM30 : IYmmRegOp<YMM30,N30>
        {
            public Fixed256 Value {get;}

            public K Kind => K.YMM30;
        }

        public readonly struct YMM31 : IYmmRegOp<YMM31,N31>
        {
            public Fixed256 Value {get;}
            public K Kind => K.YMM31;
        }
    }
}