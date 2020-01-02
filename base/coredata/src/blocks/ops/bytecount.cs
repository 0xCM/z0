//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Computes the number of bytes covered by a specified cell count and width
        /// </summary>
        /// <param name="cellcount">The number of allocated cells</param>
        /// <param name="cellwidth">The bit-width of a cell</param>
        [MethodImpl(Inline)]
        public static int bytecount(int cellcount, int cellwidth)
            => cellcount * (cellwidth/8);

        /// <summary>
        /// Computes  the number of bytes covered by a specified cell count of parametric type
        /// </summary>
        /// <param name="cellcount">The number of allocated cells</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int bytecount<T>(int cellcount)
            => cellcount * Unsafe.SizeOf<T>();
    }
}