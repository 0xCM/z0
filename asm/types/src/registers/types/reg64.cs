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
        public readonly struct rax : reg64<rax,N0>
        {
            public const uint Width = reg64.Width;

            public const int Index = 0;

            public S State {get;}

            public K Kind => RAX;
        }

        public readonly struct rcx : reg64<rcx,N1>
        {
            public const uint Width = reg64.Width;

            public const int Index = 1;

            public S State {get;}

            public K Kind => RAX;
        }    

        public readonly struct rdx : reg64<rdx,N2>
        {
            public const uint Width = reg64.Width;

            public const int Index = 2;

            public S State {get;}

            public K Kind => RDX;
        }    

        public readonly struct rbx : reg64<rbx,N3>
        {
            public const uint Width = reg64.Width;

            public const int Index = 3;

            public S State {get;}

            public K Kind => RBX;
        }    

        public readonly struct rsi : reg64<rsi,N4>
        {
            public const uint Width = reg64.Width;

            public const int Index = 4;

            public S State {get;}

            public K Kind => RSI;
        }    

        public readonly struct rdi : reg64<rdi,N5>
        {
            public const uint Width = reg64.Width;

            public const int Index = 5;

            public S State {get;}

            public K Kind => RDI;
        }        

        public readonly struct rsp : reg64<rsp,N6>
        {
            public const uint Width = reg64.Width;

            public const int Index = 6;

            public S State {get;}

            public K Kind => RSP;
        }            

        public readonly struct rbp : reg64<rbp,N7>
        {
            public const uint Width = reg64.Width;

            public const int Index = 7;

            public S State {get;}

            public K Kind => RBP;
        }                

        public readonly struct r8 : reg64<r8,N8>
        {
            public const uint Width = reg64.Width;

            public const int Index = 8;

            public S State {get;}

            public K Kind => K.R8;
        }                    

        public readonly struct r9 : reg64<r9,N9>
        {
            public const uint Width = reg64.Width;

            public const int Index = 9;

            public S State {get;}

            public K Kind => R9;
        }                        

        public readonly struct r10 : reg64<r10,N10>
        {
            public const uint Width = reg64.Width;

            public const int Index = 10;

            public S State {get;}

            public K Kind => R10;
        }                        

        public readonly struct r11 : reg64<r11,N11>
        {
            public const uint Width = reg64.Width;

            public const int Index = 11;

            public S State {get;}

            public K Kind => R11;
        }                        

        public readonly struct r12 : reg64<r12,N12>
        {
            public const uint Width = reg64.Width;

            public const int Index = 12;

            public S State {get;}

            public K Kind => R12;
        }                    

        public readonly struct r13 : reg64<r13,N13>
        {
            public const uint Width = reg64.Width;

            public const int Index = 13;

            public S State {get;}

            public K Kind => R13;
        }                        

        public readonly struct r14 : reg64<r14,N14>
        {
            public const uint Width = reg64.Width;

            public const int Index = 14;

            public S State {get;}

            public K Kind => R14;
        }                        

        public readonly struct r15 : reg64<r15,N15>
        {
            public const uint Width = reg64.Width;

            public const int Index = 14;

            public S State {get;}

            public K Kind => R15;
        }
    }
}