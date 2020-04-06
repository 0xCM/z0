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
        public readonly struct ax : regG16<ax,N0>
        {
            public S State {get;}

            public K Kind => AX;
        }

        public readonly struct cx : regG16<cx,N1>
        {
            public S State {get;}

            public K Kind => CX;
        }    

        public readonly struct dx : regG16<dx,N2>
        {
            public S State {get;}

            public K Kind => DX;
        }    

        public readonly struct bx : regG16<bx,N3>
        {
            public S State {get;}

            public K Kind => BX;
        }    

        public readonly struct si : regG16<si,N4>
        {
            public S State {get;}

            public K Kind => SI;
        }    

        public readonly struct di : regG16<di,N5>
        {
            public S State {get;}

            public K Kind => DI;
        }        

        public readonly struct sp : regG16<sp,N6>
        {
            public S State {get;}

            public K Kind => SP;
        }            

        public readonly struct bp : regG16<bp,N7>
        {
            public S State {get;}

            public K Kind => AX;
        }                

        public readonly struct r8w : regG16<r8w,N8>
        {
            public S State {get;}

            public K Kind => R8W;
        }                    

        public readonly struct r9w : regG16<r9w,N9>
        {
            public S State {get;}

            public K Kind => R9W;
        }                        

        public readonly struct r11w : regG16<r11w,N11>
        {
            public S State {get;}

            public K Kind => R11W;
        }                        

        public readonly struct r12w : regG16<r12w,N12>
        {
            public S State {get;}

            public K Kind => R12W;
        }                    

        public readonly struct r13w : regG16<r13w,N13>
        {
            public S State {get;}

            public K Kind => R13W;
        }                        

        public readonly struct r14w : regG16<r14w,N14>
        {
            public S State {get;}

            public K Kind => R14W;
        }                        

        public readonly struct r15w : regG16<r15w,N15>
        {
            public S State {get;}

            public K Kind => R15W;
        }
    }
}