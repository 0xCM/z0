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
        /// Adds an offset to the source reference, measured relative to 32-bit segments, and returns the reinterpreted reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint seek32<T>(in T src, uint count)
            => ref Add(ref As<T,uint>(ref edit(src)), (int)count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the reinterpreted reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint seek32<T>(Span<T> src, uint count)
            => ref Add(ref As<T,uint>(ref first(src)), (int)count);
    }
}