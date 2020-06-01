//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{

    using K = RegisterKind;
        
    partial class Registers
    {        
        public readonly struct AL : IRegOp8<AL,N0>
        {
            
            public K Kind => K.AL;
        }

        public readonly struct CL : IRegOp8<CL,N1>
        {
        
            public K Kind => K.CL;
        }    

        public readonly struct DL : IRegOp8<DL,N2>
        {
            
            public K Kind => K.DL;
        }    

        public readonly struct BL : IRegOp8<BL,N3>
        {
            

            public const int Index = 3;

            

            public K Kind => K.BL;
        }    

        public readonly struct SIL : IRegOp8<SIL,N4>
        {
            

            public const int Index = 4;

            

            public K Kind => K.SIL;
        }    

        public readonly struct DIL : IRegOp8<DIL,N5>
        {
            

            public const int Index = 5;

            

            public K Kind => K.DIL;
        }        

        public readonly struct SPL : IRegOp8<SPL,N6>
        {
            public const int Index = 6;

            

            

            public K Kind => K.SPL;
        }            

        public readonly struct BPL : IRegOp8<BPL,N7>
        {
            public const int Index = 7;

            
         
            public K Kind => K.BPL;
        }                

        public readonly struct R8B : IRegOp8<R8B,N8>
        {
            public const int Index = 8;

            
            
            public K Kind => K.R8L;
        }                    

        public readonly struct R9B : IRegOp8<R9B,N9>
        {
            public const int Index = 9;

            
            
            public K Kind => K.R9L;
        }                        

        public readonly struct R10B : IRegOp8<R10B,N10>
        {
            public const int Index = 10;

            
            
            public K Kind => K.R10L;
        }                        

        public readonly struct R11B : IRegOp8<R11B,N11>
        {
            public const int Index = 11;

            

            

            public K Kind => K.R11L;
        }                        

        public readonly struct R12B : IRegOp8<R12B,N12>
        {
            public const int Index = 12;

            
            

            public K Kind => K.R12L;
        }                    

        public readonly struct R13B : IRegOp8<R13B,N13>
        {
            public const int Index = 13;

            
        
            public K Kind => K.R13L;
        }                        

        public readonly struct R14B : IRegOp8<R14B,N14>
        {
            public const int Index = 14;

            
        
            public K Kind => K.R14L;
        }                        

        public readonly struct R15B : IRegOp8<R15B,N15>
        {
            public const int Index = 15;

            

            public K Kind => K.R15L;
        }
    }
}