//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;
    using static RegisterKind;

    using S = Fixed64;
    using K = RegisterKind;

    
    partial class Registers
    {
        public readonly struct rax : regG64<rax,N0>
        {
            public S State {get;}

            public K Kind => RAX;

        }

        public readonly struct rcx : regG64<rcx,N1>
        {
            public S State {get;}

            public K Kind => RAX;
        }    

        public readonly struct rdx : regG64<rdx,N2>
        {
            public S State {get;}

            public K Kind => RDX;
        }    

        public readonly struct rbx : regG64<rbx,N3>
        {
            public S State {get;}

            public K Kind => RBX;
        }    

        public readonly struct rsi : regG64<rsi,N4>
        {
            public S State {get;}

            public K Kind => RSI;
        }    

        public readonly struct rdi : regG64<rdi,N5>
        {
            public S State {get;}

            public K Kind => RDI;
        }        

        public readonly struct rsp : regG64<rsp,N6>
        {
            public S State {get;}

            public K Kind => RSP;
        }            

        public readonly struct rbp : regG64<rbp,N7>
        {
            public S State {get;}

            public K Kind => RBP;
        }                

        public readonly struct r8 : regG64<r8,N8>
        {
            public S State {get;}

            public K Kind => R8;
        }                    

        public readonly struct r9 : regG64<r9,N9>
        {
            public S State {get;}

            public K Kind => R9;
        }                        

        public readonly struct r10 : regG64<r10,N10>
        {
            public S State {get;}

            public K Kind => R10;
        }                        

        public readonly struct r11 : regG64<r11,N11>
        {
            public S State {get;}

            public K Kind => R11;
        }                        

        public readonly struct r12 : regG64<r12,N12>
        {
            public S State {get;}

            public K Kind => R12;
        }                    

        public readonly struct r13 : regG64<r13,N13>
        {
            public S State {get;}

            public K Kind => R13;
        }                        

        public readonly struct r14 : regG64<r14,N14>
        {
            public S State {get;}

            public K Kind => R14;
        }                        

        public readonly struct r15 : regG64<r15,N15>
        {
            public S State {get;}

            public K Kind => R15;
        }
    }
}