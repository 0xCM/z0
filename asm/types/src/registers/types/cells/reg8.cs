//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    
    using static AsmSpecs;
    using static RegisterKind;

    using S = Fixed8;
    using K = RegisterKind;
    
    partial class Registers
    {
        public readonly struct al : regG8<al,N0>
        {
            public S State {get;}

            public K Kind => AL;
        }

        public readonly struct cl : regG8<cl,N1>
        {
            public S State {get;}

            public K Kind => CL;
        }    


        public readonly struct dl : regG8<dl,N2>
        {
            public S State {get;}

            public K Kind => DL;
        }    

        public readonly struct bl : regG8<bl,N3>
        {
            public S State {get;}

            public K Kind => BL;
        }    

        public readonly struct sil : regG8<sil,N4>
        {
            public S State {get;}

            public K Kind => SIL;
        }    

        public readonly struct dil : regG8<dil,N5>
        {
            public S State {get;}

            public K Kind => DIL;
        }        

        public readonly struct spl : regG8<spl,N6>
        {
            public S State {get;}

            public K Kind => SPL;
        }            

        public readonly struct bpl : regG8<bpl,N7>
        {
            public S State {get;}
         
            public K Kind => BPL;
        }                

        public readonly struct r8b : regG8<r8b,N8>
        {
            public S State {get;}

            public K Kind => R8B;
        }                    

        public readonly struct r9b : regG8<r9b,N9>
        {
            public S State {get;}

            public K Kind => R9B;
        }                        

        public readonly struct r10b : regG8<r10b,N10>
        {
            public S State {get;}

            public K Kind => R10B;
        }                        

        public readonly struct r11b : regG8<r11b,N11>
        {
            public S State {get;}

            public K Kind => R11B;
        }                        

        public readonly struct r12b : regG8<r12b,N12>
        {
            public S State {get;}

            public K Kind => R12B;
        }                    

        public readonly struct r13b : regG8<r13b,N13>
        {
            public S State {get;}

            public K Kind => R13B;
        }                        

        public readonly struct r14b : regG8<r14b,N14>
        {
            public S State {get;}

            public K Kind => R14B;
        }                        

        public readonly struct r15b : regG8<r15b,N15>
        {
            public S State {get;}

            public K Kind => R15B;
        }

    }
}