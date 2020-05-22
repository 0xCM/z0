//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{    

    using K = Z0.Asm.Data.RegisterKind;

    partial class Registers
    {
        public readonly struct AX : IReg16<AX,N0>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 0;

            

            public K Kind => K.AX;
        }

        public readonly struct CX : IReg16<CX,N1>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 1;

            

            public K Kind => K.CX;
        }    

        public readonly struct DX : IReg16<DX,N2>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 2;

            

            public K Kind => K.DX;
        }    

        public readonly struct BX : IReg16<BX,N3>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 3;
        
            public K Kind => K.BX;
        }    

        public readonly struct SI : IReg16<SI,N4>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 4;

            

            public K Kind => K.SI;
        }    

        public readonly struct DI : IReg16<DI,N5>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 5;

            

            public K Kind => K.DI;
        }        

        public readonly struct SP : IReg16<SP,N6>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 6;

            

            public K Kind => K.SP;
        }            

        public readonly struct BP : IReg16<BP,N7>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 7;

            

            public K Kind => K.AX;
        }                

        public readonly struct R8W : IReg16<R8W,N8>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 8;

            

            public K Kind => K.R8W;
        }                    

        public readonly struct R9W : IReg16<R9W,N9>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 9;

            

            public K Kind => K.R9W;
        }                        

        public readonly struct R10W : IReg16<R10W,N10>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 10;

            

            public K Kind => K.R10W;
        }                        

        public readonly struct R11W : IReg16<R11W,N11>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 11;

            

            public K Kind => K.R11W;
        }                        

        public readonly struct R12W : IReg16<R12W,N12>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 12;

            

            public K Kind => K.R12W;
        }                    

        public readonly struct R13W : IReg16<R13W,N13>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 13;

            

            public K Kind => K.R13W;
        }                        

        public readonly struct R14W : IReg16<R14W,N14>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 14;

            

            public K Kind => K.R14W;
        }                        

        public readonly struct R15W : IReg16<R15W,N15>
        {
            public const uint Width = IReg16.Width;

            public const int Index = 15;
        
            public K Kind => K.R15W;
        }
    }
}