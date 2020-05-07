//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;
    using static RegisterKind;

    using S = Fixed32;
    using K = RegisterKind;

    partial class Registers
    {

        public readonly struct eax : reg32<eax,N0>
        {
            public const uint Width = reg32.Width;

            public const int Index = 0;

            public S State {get;}
        
            public K Kind => EAX;
        }

        public readonly struct ecx : reg32<ecx,N1>
        {
            public const uint Width = reg32.Width;

            public const int Index = 1;

            public S State {get;}

            public K Kind => ECX;
        }    

        public readonly struct edx : reg32<edx,N2>
        {
            public const uint Width = reg32.Width;

            public const int Index = 2;

            public S State {get;}

            public K Kind => EDX;
        }    

        public readonly struct ebx : reg32<ebx,N3>
        {
            public const uint Width = reg32.Width;

            public const int Index = 3;

            public S State {get;}

            public K Kind => EBX;
        }    

        public readonly struct esi : reg32<esi,N4>
        {
            public const uint Width = reg32.Width;

            public const int Index = 4;

            public S State {get;}

            public K Kind => ESI;
        }    

        public readonly struct edi : reg32<edi,N5>
        {
            public const uint Width = reg32.Width;

            public const int Index = 5;

            public S State {get;}

            public K Kind => EDI;
        }        

        public readonly struct esp : reg32<esp,N6>
        {
            public const uint Width = reg32.Width;

            public const int Index = 6;

            public S State {get;}

            public K Kind => ESP;
        }            

        public readonly struct ebp : reg32<ebp,N7>
        {
            public const uint Width = reg32.Width;

            public const int Index = 7;

            public S State {get;}

            public K Kind => EBP;
        }                

        public readonly struct r8d : reg32<r8d,N8>
        {
            public const uint Width = reg32.Width;

            public const int Index = 8;

            public S State {get;}

            public K Kind => R8D;
        }                    

        public readonly struct r9d : reg32<r9d,N9>
        {
            public const uint Width = reg32.Width;

            public const int Index = 9;

            public S State {get;}

            public K Kind => R9D;
        }                        

        public readonly struct r10d : reg32<r10d,N10>
        {
            public const uint Width = reg32.Width;

            public const int Index = 10;

            public S State {get;}

            public K Kind => R10D;
        }                        

        public readonly struct r11d : reg32<r11d,N11>
        {
            public const uint Width = reg32.Width;

            public const int Index = 11;

            public S State {get;}

            public K Kind => R11D;
        }                        

        public readonly struct r12d : reg32<r12d,N12>
        {
            public const uint Width = reg32.Width;

            public const int Index = 12;

            public S State {get;}

            public K Kind => R12D;
        }                    

        public readonly struct r13d : reg32<r13d,N13>
        {
            public const uint Width = reg32.Width;

            public const int Index = 13;

            public S State {get;}

            public K Kind => R13D;
        }                        

        public readonly struct r14d : reg32<r14d,N14>
        {
            public const uint Width = reg32.Width;

            public const int Index = 14;

            public S State {get;}

            public K Kind => R14D;
        }                        

        public readonly struct r15d : reg32<r15d,N15>
        {
            public const uint Width = reg32.Width;

            public const int Index = 15;

            public S State {get;}

            public K Kind => R15D;
        }
    }
}