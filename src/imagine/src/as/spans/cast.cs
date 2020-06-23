//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Produces a target T-span from a source bytespan populated with a maximal
        /// number of elemements obtainable from the source bytes; remaining bytes, if
        /// any, are deposited into a remainder bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="rem">The span populated with left-over bytes, if any</param>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<byte> src, out Span<byte> rem)
            where T : struct
                => cast<byte,T>(src, out rem);

        /// <summary>
        /// Produces a target T-span from a source bytespan populated with a maximal
        /// number of elemements obtainable from the source bytes; remaining bytes, if
        /// any, are deposited into a remainder bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="rem">The span populated with left-over bytes, if any</param>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, out ReadOnlySpan<byte> rem)
            where T : struct
                => cast<byte,T>(src, out rem);
    }
}