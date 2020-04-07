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
        public readonly struct Reg8 : reg8<Fixed8>
        {    
            public const uint Width = reg8.Width;

            public Fixed8 State {get;}
        }

        public readonly struct Reg8<N> : reg8<Reg8<N>, N>
            where N : unmanaged, ITypeNat
        {
            public const uint Width = reg8.Width;

            public Fixed8 State {get;}
        }

        public readonly struct al : reg8<al,N0>
        {
            public const uint Width = reg8.Width;

            public const int Index = 0;

            public S State {get;}

            public K Kind => AL;
        }

        public readonly struct cl : reg8<cl,N1>
        {
            public const uint Width = reg8.Width;

            public const int Index = 1;

            public S State {get;}

            public K Kind => CL;
        }    

        public readonly struct dl : reg8<dl,N2>
        {
            public const uint Width = reg8.Width;

            public const int Index = 2;

            public S State {get;}

            public K Kind => DL;
        }    

        public readonly struct bl : reg8<bl,N3>
        {
            public const uint Width = reg8.Width;

            public const int Index = 3;

            public S State {get;}

            public K Kind => BL;
        }    

        public readonly struct sil : reg8<sil,N4>
        {
            public const uint Width = reg8.Width;

            public const int Index = 4;

            public S State {get;}

            public K Kind => SIL;
        }    

        public readonly struct dil : reg8<dil,N5>
        {
            public const uint Width = reg8.Width;

            public const int Index = 5;

            public S State {get;}

            public K Kind => DIL;
        }        

        public readonly struct spl : reg8<spl,N6>
        {
            public const int Index = 6;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => SPL;
        }            

        public readonly struct bpl : reg8<bpl,N7>
        {
            public const int Index = 7;

            public S State {get;}
         
            public K Kind => BPL;
        }                

        public readonly struct r8b : reg8<r8b,N8>
        {
            public const int Index = 8;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R8B;
        }                    

        public readonly struct r9b : reg8<r9b,N9>
        {
            public const int Index = 9;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R9B;
        }                        

        public readonly struct r10b : reg8<r10b,N10>
        {
            public const int Index = 10;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R10B;
        }                        

        public readonly struct r11b : reg8<r11b,N11>
        {
            public const int Index = 11;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R11B;
        }                        

        public readonly struct r12b : reg8<r12b,N12>
        {
            public const int Index = 12;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R12B;
        }                    

        public readonly struct r13b : reg8<r13b,N13>
        {
            public const int Index = 13;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R13B;
        }                        

        public readonly struct r14b : reg8<r14b,N14>
        {
            public const int Index = 14;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R14B;
        }                        

        public readonly struct r15b : reg8<r15b,N15>
        {
            public const int Index = 15;

            public const uint Width = reg8.Width;

            public S State {get;}

            public K Kind => R15B;
        }
    }
}