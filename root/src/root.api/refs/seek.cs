//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {
        /// <summary>
        /// Adds an offset to a reference, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(ref T src, int count)
            => ref refs.seek(ref src, count);

        [MethodImpl(Inline)]
        public static ref ulong seek64<T>(ref T src, int count)
            => ref refs.seek64(ref src, count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 64-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong seek64<T>(Span<T> src, int count)
            => ref Spans.seek64(src,count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref Spans.seek(src,count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(T[] src, int count)
            => ref refs.seek(src,count);
    }
}