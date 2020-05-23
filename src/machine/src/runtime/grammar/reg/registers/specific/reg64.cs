//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using K = Z0.Asm.Data.RegisterKind;
    
    partial class Registers
    {
        public readonly struct RAX : IReg64<RAX,N0>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 0;
        
            public K Kind => K.RAX;
        }

        public readonly struct RCX : IReg64<RCX,N1>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 1;

            

            public K Kind => K.RAX;
        }    

        public readonly struct RDX : IReg64<RDX,N2>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 2;

            

            public K Kind => K.RDX;
        }    

        public readonly struct RBX : IReg64<RBX,N3>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 3;

            

            public K Kind => K.RBX;
        }    

        public readonly struct RSI : IReg64<RSI,N4>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 4;

            

            public K Kind => K.RSI;
        }    

        public readonly struct RDI : IReg64<RDI,N5>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 5;

            

            public K Kind => K.RDI;
        }        

        public readonly struct RSP : IReg64<RSP,N6>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 6;

            

            public K Kind => K.RSP;
        }            

        public readonly struct RBP : IReg64<RBP,N7>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 7;

            

            public K Kind => K.RBP;
        }                

        public readonly struct R8 : IReg64<R8,N8>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 8;

            

            public K Kind => K.R8;
        }                    

        public readonly struct R9 : IReg64<R9,N9>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 9;

            

            public K Kind => K.R9;
        }                        

        public readonly struct R10 : IReg64<R10,N10>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 10;

            

            public K Kind => K.R10;
        }                        

        public readonly struct R11 : IReg64<R11,N11>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 11;

            

            public K Kind => K.R11;
        }                        

        public readonly struct R12 : IReg64<R12,N12>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 12;

            

            public K Kind => K.R12;
        }                    

        public readonly struct R13 : IReg64<R13,N13>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 13;

            

            public K Kind => K.R13;
        }                        

        public readonly struct R14 : IReg64<R14,N14>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 14;

            

            public K Kind => K.R14;
        }                        

        public readonly struct R15 : IReg64<R15,N15>
        {
            public const uint Width = IReg64.Width;

            public const int Index = 14;
        
            public K Kind => K.R15;
        }
    }
}