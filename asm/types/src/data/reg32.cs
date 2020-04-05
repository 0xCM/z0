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
        public interface reg32 : reg<W32>
        {

        }

        public interface reg32<F> : reg32, reg<F,W32>
            where F : struct, reg32<F>
        {

        }
    }

    partial class AsmCells
    {
        public readonly struct eax : reg32<eax>
        {

        }

        public readonly struct ecx : reg32<ecx>
        {

        }    

        public readonly struct edx : reg32<edx>
        {

        }    

        public readonly struct ebx : reg32<ebx>
        {

        }    

        public readonly struct esi : reg32<esi>
        {


        }    

        public readonly struct edi : reg32<edi>
        {


        }        

        public readonly struct esp : reg32<esp>
        {


        }            

        public readonly struct ebp : reg32<ebp>
        {


        }                

        public readonly struct r8d : reg32<r8d>
        {


        }                    

        public readonly struct r9d : reg32<r9d>
        {


        }                        

        public readonly struct r10d : reg32<r10d>
        {


        }                        

        public readonly struct r11d : reg32<r11d>
        {


        }                        

        public readonly struct r12d : reg32<r12d>
        {


        }                    

        public readonly struct r13d : reg32<r13d>
        {


        }                        

        public readonly struct r14d : reg32<r14d>
        {


        }                        

        public readonly struct r15d : reg32<r15d>
        {


        }
    }
}