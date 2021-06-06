//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint skip32<T>(in T src, long count)
            => ref Add(ref As<T,uint>(ref edit(src)), (int)count);

        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint skip32<T>(in T src, ulong count)
            => ref Add(ref As<T,uint>(ref edit(src)), (int)count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint skip32<T>(ReadOnlySpan<T> src, long count)
            => ref Add(ref As<T,uint>(ref edit(first(src))), (int)count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint skip32<T>(ReadOnlySpan<T> src, ulong count)
            => ref Add(ref As<T,uint>(ref edit(first(src))), (int)count);
    }
}