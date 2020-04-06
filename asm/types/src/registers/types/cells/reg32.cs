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
        public readonly struct eax : regG32<eax,N0>
        {
            public S State {get;}
        
            public K Kind => EAX;
        }

        public readonly struct ecx : regG32<ecx,N1>
        {
            public S State {get;}

            public K Kind => ECX;
        }    

        public readonly struct edx : regG32<edx,N2>
        {
            public S State {get;}

            public K Kind => EDX;
        }    

        public readonly struct ebx : regG32<ebx,N3>
        {
            public S State {get;}

            public K Kind => EBX;
        }    

        public readonly struct esi : regG32<esi,N4>
        {
            public S State {get;}

            public K Kind => ESI;
        }    

        public readonly struct edi : regG32<edi,N5>
        {
            public S State {get;}

            public K Kind => EDI;
        }        

        public readonly struct esp : regG32<esp,N6>
        {
            public S State {get;}

            public K Kind => ESP;
        }            

        public readonly struct ebp : regG32<ebp,N7>
        {
            public S State {get;}

            public K Kind => EBP;
        }                

        public readonly struct r8d : regG32<r8d,N8>
        {
            public S State {get;}

            public K Kind => R8D;
        }                    

        public readonly struct r9d : regG32<r9d,N9>
        {
            public S State {get;}

            public K Kind => R9D;
        }                        

        public readonly struct r10d : regG32<r10d,N10>
        {
            public S State {get;}

            public K Kind => R10D;
        }                        

        public readonly struct r11d : regG32<r11d,N11>
        {
            public S State {get;}

            public K Kind => R11D;
        }                        

        public readonly struct r12d : regG32<r12d,N12>
        {
            public S State {get;}

            public K Kind => R12D;
        }                    

        public readonly struct r13d : regG32<r13d,N13>
        {
            public S State {get;}

            public K Kind => R13D;
        }                        

        public readonly struct r14d : regG32<r14d,N14>
        {
            public S State {get;}

            public K Kind => R14D;
        }                        

        public readonly struct r15d : regG32<r15d,N15>
        {
            public S State {get;}

            public K Kind => R15D;
        }
    }
}