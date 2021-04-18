//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Allocates a buffer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static NativeCells<F> native<F>(byte count)
            where F : unmanaged, IDataCell
        {
            var bufferSize = (uint)default(F).Size;
            var totalSize = count*(bufferSize);
            var allocated = NativeBuffer.alloc(totalSize);
            return new NativeCells<F>(allocated, count, bufferSize, totalSize);
        }
    }
}