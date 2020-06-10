//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{    

    using K = RegisterKind;

    partial class Regs
    {
        public readonly struct ax : IRegOp16<ax,N0>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.AX;
        }

        public readonly struct cx : IRegOp16<cx,N1>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.CX;
        }    

        public readonly struct dx : IRegOp16<dx,N2>
        {        
            public Fixed16 Value  {get;}

            public K Kind => K.DX;
        }    

        public readonly struct bx : IRegOp16<bx,N3>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.BX;
        }    

        public readonly struct si : IRegOp16<si,N4>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.SI;
        }    

        public readonly struct di : IRegOp16<di,N5>
        {
            public Fixed16 Value  {get;}
            public K Kind => K.DI;
        }        

        public readonly struct sp : IRegOp16<sp,N6>
        {            
            public Fixed16 Value  {get;}
            public K Kind => K.SP;
        }            

        public readonly struct bp : IRegOp16<bp,N7>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.AX;
        }                

        public readonly struct r8w : IRegOp16<r8w,N8>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.R8W;
        }                    

        public readonly struct r9w : IRegOp16<r9w,N9>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.R9W;
        }                        

        public readonly struct R10w : IRegOp16<R10w,N10>
        {        
            public Fixed16 Value  {get;}

            public K Kind => K.R10W;
        }                        

        public readonly struct r11w : IRegOp16<r11w,N11>
        {            
            public Fixed16 Value  {get;}

            public K Kind => K.R11W;
        }                        

        public readonly struct r12w : IRegOp16<r12w,N12>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.R12W;
        }                    

        public readonly struct r13w : IRegOp16<r13w,N13>
        {
            public Fixed16 Value  {get;}

            public K Kind => K.R13W;
        }                        

        public readonly struct r14w : IRegOp16<r14w,N14>
        {            
            public Fixed16 Value  {get;}

            public K Kind => K.R14W;
        }                        

        public readonly struct r15w : IRegOp16<r15w,N15>
        {
            public Fixed16 Value  {get;}
            public K Kind => K.R15W;
        }
    }
}