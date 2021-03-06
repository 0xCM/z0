//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    unsafe partial struct Buffers
    {
        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="size">The buffer length in bytes</param>
        [Op]
        public static NativeBuffer native(ByteSize size)
            => new NativeBuffer((liberate(Marshal.AllocHGlobal((int)size), (int)size), size));

        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="size">The buffer length in bytes</param>
        [Op]
        public static NativeBuffer<T> native<T>(ByteSize size)
            where T : unmanaged
                => new NativeBuffer<T>((liberate(Marshal.AllocHGlobal((int)size), (int)size), size));

        /// <summary>
        /// Creates a buffer sequence that owns the underlying memory allocation and releases it upon disposal
        /// </summary>
        /// <param name="segsize">The size of each buffer</param>
        /// <param name="segcount">The number of buffers to allocate</param>
        [Op]
        public static NativeBuffers native(ByteSize segsize, byte segcount)
        {
            var allocation = native(segsize*segcount);
            return new NativeBuffers(segsize, segcount, allocation, tokenize(allocation.Handle, segsize, segcount));
        }
    }
}