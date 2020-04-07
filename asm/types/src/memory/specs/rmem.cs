//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0;
    using static AsmTypes;

    partial class AsmSpecs
    {
        /// <summary>
        public interface rmem<W> : reg<W>, mem<W>
            where W : unmanaged, IDataWidth
        {


        }

        public interface rmem<F,W,T,A> : rmem<W>, reg<F,W,T>, mem<F,W,A>
            where F : struct, rmem<F,W,T,A>
            where W : unmanaged, IDataWidth
            where A : unmanaged, address<W>
            where T : unmanaged
        {
        
        }

        public interface rmem8<F> : rmem<F,W8,Fixed8,address8>
            where F : struct, rmem8<F>
        {
               
        }

        public interface rmem16<F> : rmem<F,W16, Fixed16, address16>
            where F : struct, rmem16<F>
        {

        }

        public interface rmem32<F> : rmem<F,W32, Fixed32, address32>
            where F : struct, rmem32<F>
        {

        }

        public interface rmem64<F> : rmem<F,W64, Fixed64, address64>
            where F : struct, rmem64<F>
        {

        }
    }
}