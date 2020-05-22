//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{

    using K = Z0.Asm.Data.RegisterKind;
        
    partial class Registers
    {        
        public readonly struct AL : IReg8<AL,N0>
        {
            public const uint Width = IReg8.Width;

            public const int Index = 0;
            
            public K Kind => K.AL;
        }

        public readonly struct CL : IReg8<CL,N1>
        {
            public const uint Width = IReg8.Width;

            public const int Index = 1;

        
            public K Kind => K.CL;
        }    

        public readonly struct DL : IReg8<DL,N2>
        {
            public const uint Width = IReg8.Width;

            public const int Index = 2;

            

            public K Kind => K.DL;
        }    

        public readonly struct BL : IReg8<BL,N3>
        {
            public const uint Width = IReg8.Width;

            public const int Index = 3;

            

            public K Kind => K.BL;
        }    

        public readonly struct SIL : IReg8<SIL,N4>
        {
            public const uint Width = IReg8.Width;

            public const int Index = 4;

            

            public K Kind => K.SIL;
        }    

        public readonly struct DIL : IReg8<DIL,N5>
        {
            public const uint Width = IReg8.Width;

            public const int Index = 5;

            

            public K Kind => K.DIL;
        }        

        public readonly struct SPL : IReg8<SPL,N6>
        {
            public const int Index = 6;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.SPL;
        }            

        public readonly struct BPL : IReg8<BPL,N7>
        {
            public const int Index = 7;

            
         
            public K Kind => K.BPL;
        }                

        public readonly struct R8B : IReg8<R8B,N8>
        {
            public const int Index = 8;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R8B;
        }                    

        public readonly struct R9B : IReg8<R9B,N9>
        {
            public const int Index = 9;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R9B;
        }                        

        public readonly struct R10B : IReg8<R10B,N10>
        {
            public const int Index = 10;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R10B;
        }                        

        public readonly struct R11B : IReg8<R11B,N11>
        {
            public const int Index = 11;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R11B;
        }                        

        public readonly struct R12B : IReg8<R12B,N12>
        {
            public const int Index = 12;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R12B;
        }                    

        public readonly struct R13B : IReg8<R13B,N13>
        {
            public const int Index = 13;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R13B;
        }                        

        public readonly struct R14B : IReg8<R14B,N14>
        {
            public const int Index = 14;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R14B;
        }                        

        public readonly struct R15B : IReg8<R15B,N15>
        {
            public const int Index = 15;

            public const uint Width = IReg8.Width;

            

            public K Kind => K.R15B;
        }
    }
}