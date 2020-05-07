//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
 
    partial class AsmSpecs
    {
        public interface mem<W> : data<W>
            where W : unmanaged, IDataWidth
        {

        }
    
        /// <summary>
        /// Characterizes a memory segment of parametric width and known location
        /// </summary>
        public interface mem<F,W,S> : mem<W>
            where F : struct, mem<F,W,S>
            where W : unmanaged, IDataWidth
            where S : unmanaged
        {
            S Content {get;}
        }

        /// <summary>
        /// Characterizes a memory segment of parametric width and known location
        /// </summary>
        public interface mem<F,W,S,A> : mem<F,W,S>
            where F : struct, mem<F,W,S,A>
            where W : unmanaged, IDataWidth
            where S : unmanaged
            where A : address<W>
        {
            A Location {get;}            
        }

    }
}