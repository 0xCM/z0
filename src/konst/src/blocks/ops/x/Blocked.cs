//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BXTend
    {
        /// <summary>
        /// Constructs a 32-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock8<T> Blocked<T>(this Span<T> src, W8 w)
             where T : unmanaged
                => Blocks.load(w,src);

        /// <summary>
        /// Constructs a 32-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock16<T> Blocked<T>(this Span<T> src, W16 w)
             where T : unmanaged
                => Blocks.load(w,src);

        /// <summary>
        /// Constructs a 32-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock32<T> Blocked<T>(this Span<T> src, W32 w)
             where T : unmanaged
                => Blocks.load(w,src);

        /// <summary>
        /// Constructs a 16-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock64<T> Blocked<T>(this Span<T> src, W64 w)
             where T : unmanaged
                => Blocks.load(w,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock128<T> Blocked<T>(this Span<T> src, W128 w)
             where T : unmanaged
                => Blocks.load(w,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock256<T> Blocked<T>(this Span<T> src, W256 w)
             where T : unmanaged
                => Blocks.load(w,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock512<T> Blocked<T>(this Span<T> src, W512 w)
             where T : unmanaged
                => Blocks.load(w,src);
    }
}