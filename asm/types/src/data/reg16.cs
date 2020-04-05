//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSpecs;
    using static AsmTypes;

    partial class AsmSpecs
    {
        public interface reg16 : reg<W16>
        {

        }

        public interface reg16<F> : reg16, reg<F,W16>
            where F : struct, reg16<F>
        {

        }
    }

    partial class AsmCells
    {
        public readonly struct ax : reg16<ax>
        {

        }

        public readonly struct cx : reg16<cx>
        {

        }    

        public readonly struct dx : reg16<dx>
        {

        }    

        public readonly struct bx : reg16<bx>
        {

        }    

        public readonly struct si : reg16<si>
        {

        }    

        public readonly struct di : reg16<di>
        {


        }        

        public readonly struct sp : reg16<sp>
        {

        }            

        public readonly struct bp : reg16<bp>
        {


        }                

        public readonly struct r8w : reg16<r8w>
        {


        }                    

        public readonly struct r9w : reg16<r9w>
        {


        }                        

        public readonly struct r10w : reg16<r10w>
        {


        }                        

        public readonly struct r11w : reg16<r11w>
        {


        }                        

        public readonly struct r12w : reg16<r12w>
        {


        }                    

        public readonly struct r13w : reg16<r13w>
        {


        }                        

        public readonly struct r14w : reg16<r14w>
        {


        }                        

        public readonly struct r15w : reg16<r15w>
        {


        }
    }
}