//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Buffers
    {
        /// <summary>
        /// Creates a caller-owed buffer sequence
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="length">The sequence length</param>
        /// <param name="allocation">The allocation handle that defines ownership</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffers alloc(uint size, byte length, out NativeBuffer allocation)
        {
            var buffers = NativeBuffers.alloc(size,length,false);
            allocation = buffers.Allocation;
            return buffers;
        }
    }
}