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
        /// Creates a caller-owed buffer sequence
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="length">The sequence length</param>
        /// <param name="buffer">The allocation handle that defines ownership</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffers alloc(uint size, byte length, out NativeBuffer buffer)
        {
            var buffers = NativeBuffers.alloc(size,length,false);
            buffer = buffers.Allocation;
            return buffers;
        }

        [MethodImpl(Inline)]
        public static T[] alloc<T>(uint count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline)]
        public static T[] alloc<T>(long count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline)]
        public static T[] alloc<T>(ulong count)
            => sys.alloc<T>(count);
    }
}