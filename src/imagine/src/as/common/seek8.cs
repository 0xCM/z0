//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsDeprecated
    {
        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte seek8<T>(in T src, uint count)
            => ref Add(ref As<T,byte>(ref edit(src)), (int)count);

       /// <summary>
        /// Adds an offset to the head of a span, measured relative to 8-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte seek8<T>(Span<T> src, uint count)
            => ref Add(ref As<T,byte>(ref first(src)), (int)count);
    }
}