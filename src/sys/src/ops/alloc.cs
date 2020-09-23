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
        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        // [MethodImpl(Options), Op, Closures(Closure)]
        // public static T[] alloc<T>(int count)
        //     => proxy.alloc<T>(count);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(long count)
            => proxy.alloc<T>(count);

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
        public static T[] alloc<T>(ulong count)
            => proxy.alloc<T>(count);

        /// <summary>
        /// Allocates a specified number of bytes
        /// </summary>
        /// <param name="count">The number of bytes to allocate</param>
        [MethodImpl(Options),  Op]
        public static byte[] alloc(int count)
            => proxy.alloc<byte>(count);
    }
}