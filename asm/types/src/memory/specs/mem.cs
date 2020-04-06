//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
 
    using static AsmTypes;

    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes a memory segment of known width and location
        /// </summary>
        public interface mem : data
        {
            new MemoryWidth Width {get;}            

            address Address {get;}
        }

        /// <summary>
        /// Characterizes a memory segment of parametric width and known location
        /// </summary>
        public interface mem<W> : mem
            where W : unmanaged, IDataWidth
        {
            uint sized.Size => (uint)Widths.data<W>(); 
                     
            MemoryWidth mem.Width => (MemoryWidth)Widths.data<W>();

            DataWidth data.Width => Widths.data<W>();
        }

        /// <summary>
        /// Characterizes a reified memory segment of parametric width and known location
        /// </summary>
        public interface mem<F,W> : mem<W>
            where F : struct, mem<F,W>
            where W : unmanaged, IDataWidth
        {


        }

        /// <summary>
        /// Characterizes a reified memory segment of parametric width and parametric address
        /// </summary>
        public interface mem<F,W,A> : mem<F,W>
            where F : struct, mem<F,W,A>
            where W : unmanaged, IDataWidth
            where A : struct, address<W>
        {
            new A Address {get;}
                    
            address mem.Address => new address(Address.Scalar);
        }
    }
}