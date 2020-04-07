//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    using static AsmSpecs;
    using static RegisterKind;

    using S = Fixed16;
    using K = RegisterKind;

    partial class Registers
    {
        public readonly struct Reg16 : reg16<Fixed16>
        {    
            public const uint Width = reg16.Width;

            public Fixed16 State {get;}
        }

        public readonly struct Reg16<N> : reg16<Reg16<N>, N>
            where N : unmanaged, ITypeNat
        {
            public const uint Width = reg16.Width;

            public Fixed16 State {get;}
        }
             
        public readonly struct ax : reg16<ax,N0>
        {
            public const uint Width = reg16.Width;

            public const int Index = 0;

            public S State {get;}

            public K Kind => AX;
        }

        public readonly struct cx : reg16<cx,N1>
        {
            public const uint Width = reg16.Width;

            public const int Index = 1;

            public S State {get;}

            public K Kind => CX;
        }    

        public readonly struct dx : reg16<dx,N2>
        {
            public const uint Width = reg16.Width;

            public const int Index = 2;

            public S State {get;}

            public K Kind => DX;
        }    

        public readonly struct bx : reg16<bx,N3>
        {
            public const uint Width = reg16.Width;

            public const int Index = 3;

            public S State {get;}

            public K Kind => BX;
        }    

        public readonly struct si : reg16<si,N4>
        {
            public const uint Width = reg16.Width;

            public const int Index = 4;

            public S State {get;}

            public K Kind => SI;
        }    

        public readonly struct di : reg16<di,N5>
        {
            public const uint Width = reg16.Width;

            public const int Index = 5;

            public S State {get;}

            public K Kind => DI;
        }        

        public readonly struct sp : reg16<sp,N6>
        {
            public const uint Width = reg16.Width;

            public const int Index = 6;

            public S State {get;}

            public K Kind => SP;
        }            

        public readonly struct bp : reg16<bp,N7>
        {
            public const uint Width = reg16.Width;

            public const int Index = 7;

            public S State {get;}

            public K Kind => AX;
        }                

        public readonly struct r8w : reg16<r8w,N8>
        {
            public const uint Width = reg16.Width;

            public const int Index = 8;

            public S State {get;}

            public K Kind => R8W;
        }                    

        public readonly struct r9w : reg16<r9w,N9>
        {
            public const uint Width = reg16.Width;

            public const int Index = 9;

            public S State {get;}

            public K Kind => R9W;
        }                        

        public readonly struct r10w : reg16<r10w,N10>
        {
            public const uint Width = reg16.Width;

            public const int Index = 10;

            public S State {get;}

            public K Kind => R10W;
        }                        

        public readonly struct r11w : reg16<r11w,N11>
        {
            public const uint Width = reg16.Width;

            public const int Index = 11;

            public S State {get;}

            public K Kind => R11W;
        }                        

        public readonly struct r12w : reg16<r12w,N12>
        {
            public const uint Width = reg16.Width;

            public const int Index = 12;

            public S State {get;}

            public K Kind => R12W;
        }                    

        public readonly struct r13w : reg16<r13w,N13>
        {
            public const uint Width = reg16.Width;

            public const int Index = 13;

            public S State {get;}

            public K Kind => R13W;
        }                        

        public readonly struct r14w : reg16<r14w,N14>
        {
            public const uint Width = reg16.Width;

            public const int Index = 14;

            public S State {get;}

            public K Kind => R14W;
        }                        

        public readonly struct r15w : reg16<r15w,N15>
        {
            public const uint Width = reg16.Width;

            public const int Index = 15;

            public S State {get;}

            public K Kind => R15W;
        }
    }
}