//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte seek8<T>(in T src, uint count)
            => ref add(@as<T,byte>(edit(src)), (int)count);

        /// <summary>
        /// Adds an offset to a reference, measured in bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek8g<T>(in T src, uint count)
            => ref Unsafe.AddByteOffset(ref edit(src), (IntPtr)count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 8-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte seek8<T>(Span<T> src, uint count)
            => ref add(@as<T,byte>(first(src)), (int)count);
    }
}