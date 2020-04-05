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
        /// <summary>
        /// Register or memory
        /// </summary>
        public interface rmem : reg,mem
        {


        }

        public interface rmem<W> : rmem, reg<W>
            where W : unmanaged, IDataWidth
        {
            
        }

        public interface rmem<F,W> : rmem<W>
            where F : struct, rmem<F,W>
            where W : unmanaged, IDataWidth
        {

        }

        public interface rmem8<F> : rmem<F,W8>
            where F : struct, rmem8<F>
        {

        }

        public interface rmem16<F> : rmem<F,W16>
            where F : struct, rmem16<F>
        {

        }

        public interface rmem32<F> : rmem<F,W32>
            where F : struct, rmem32<F>
        {

        }

        public interface rmem64<F> : rmem<F,W64>
            where F : struct, rmem64<F>
        {

        }
    }

    partial class AsmTypes
    {
        public readonly struct rmem8 : rmem8<rmem8>
        {

        }

        public readonly struct rmem16 : rmem16<rmem16>
        {
            
        }    

        public readonly struct rmem32 : rmem32<rmem32>
        {
            
        }        

        public readonly struct rmem64 : rmem64<rmem64>
        {
            
        }            
    }
}