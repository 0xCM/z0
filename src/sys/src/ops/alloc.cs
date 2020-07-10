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
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] alloc<T>(int count)
            => proxy.alloc<T>(count);

        [MethodImpl(Options)]
        public static T[] alloc<T>(ulong count)
            => proxy.alloc<T>((int)count);

        /// <summary>
        /// Allocates a specified number of bytes
        /// </summary>
        /// <param name="count">The number of bytes to allocate</param>
        [MethodImpl(Options),  Op]
        public static byte[] alloc(int count)
            => proxy.alloc(count);
    }
}