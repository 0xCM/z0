//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        /// <summary>
        /// Creates a buffer sequence that owns the underlying memory allocation and releases it upon disposal
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="length">The sequence length</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffers sequence(uint size, byte length)
            => new NativeBuffers(size, length);

        /// <summary>
        /// Creates a caller-owed buffer sequence
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="length">The sequence length</param>
        /// <param name="allocation">The allocation handle that defines ownership</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffers sequence(uint size, byte length, out NativeBuffer allocation)
        {
            var buffers = new NativeBuffers(size,length,false);
            allocation = buffers.Allocation;
            return buffers;
        }
    }
}