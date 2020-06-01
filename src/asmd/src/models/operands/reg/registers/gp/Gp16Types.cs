//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{    

    using K = RegisterKind;

    partial class Registers
    {
        public readonly struct AX : IRegOp16<AX,N0>
        {
            public K Kind => K.AX;
        }

        public readonly struct CX : IRegOp16<CX,N1>
        {
            public K Kind => K.CX;
        }    

        public readonly struct DX : IRegOp16<DX,N2>
        {        
            public K Kind => K.DX;
        }    

        public readonly struct BX : IRegOp16<BX,N3>
        {
            public K Kind => K.BX;
        }    

        public readonly struct SI : IRegOp16<SI,N4>
        {
            public K Kind => K.SI;
        }    

        public readonly struct DI : IRegOp16<DI,N5>
        {
            public K Kind => K.DI;
        }        

        public readonly struct SP : IRegOp16<SP,N6>
        {
            

            public const int Index = 6;

            

            public K Kind => K.SP;
        }            

        public readonly struct BP : IRegOp16<BP,N7>
        {
            

            public const int Index = 7;

            

            public K Kind => K.AX;
        }                

        public readonly struct R8W : IRegOp16<R8W,N8>
        {
            

            public const int Index = 8;

            

            public K Kind => K.R8W;
        }                    

        public readonly struct R9W : IRegOp16<R9W,N9>
        {
            

            public const int Index = 9;

            

            public K Kind => K.R9W;
        }                        

        public readonly struct R10W : IRegOp16<R10W,N10>
        {
            

            public const int Index = 10;            

            public K Kind => K.R10W;
        }                        

        public readonly struct R11W : IRegOp16<R11W,N11>
        {
            

            public const int Index = 11;
            
            public K Kind => K.R11W;
        }                        

        public readonly struct R12W : IRegOp16<R12W,N12>
        {
            

            public const int Index = 12;

            

            public K Kind => K.R12W;
        }                    

        public readonly struct R13W : IRegOp16<R13W,N13>
        {
            

            public const int Index = 13;
            
            public K Kind => K.R13W;
        }                        

        public readonly struct R14W : IRegOp16<R14W,N14>
        {
            

            public const int Index = 14;            

            public K Kind => K.R14W;
        }                        

        public readonly struct R15W : IRegOp16<R15W,N15>
        {
            

            public const int Index = 15;
        
            public K Kind => K.R15W;
        }
    }
}