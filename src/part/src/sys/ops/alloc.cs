//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct sys
    {
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(byte count)
            => proxy.alloc<T>(count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(ushort count)
            => proxy.alloc<T>(count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(uint count)
            => proxy.alloc<T>(count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(long count)
            => proxy.alloc<T>(count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(ulong count)
            => proxy.alloc<T>(count);

        /// <summary>
        /// Allocates a specified number of bytes
        /// </summary>
        /// <param name="count">The number of bytes to allocate</param>
        [MethodImpl(Options),  Op]
        public static byte[] alloc(int count)
            => proxy.alloc<byte>(count);

        /// <summary>
        /// Allocates a new array and populates it with a specified value
        /// </summary>
        /// <param name="length">The array length</param>
        /// <param name="src">The value with which to populate the array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(int length, T src)
            => proxy.fill(proxy.alloc<T>(length), src);
    }
}