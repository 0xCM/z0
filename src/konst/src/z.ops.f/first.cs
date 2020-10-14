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
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct z
    {
        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T first<T>(Span<T> src)
            => ref memory.first(src);

        /// <summary>
        /// Returns a readonly reference to the first source cell
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(ReadOnlySpan<char> src)
            => ref memory.first(src);

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T first<T>(ReadOnlySpan<T> src)
            => ref memory.first(src);

        /// <summary>
        /// Returns a readonly reference to the first cell of a readonly span, offset by a specified cell count
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The cell-measured offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T first<T>(ReadOnlySpan<T> src, int offset)
            where T : unmanaged
                => ref memory.first(src, offset);

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly byte first<T>(W8 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref As<T,byte>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ushort first<T>(W16 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref As<T,ushort>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint first<T>(W32 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref As<T,uint>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ulong first<T>(W64 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref As<T,ulong>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte first<T>(W8 w, Span<T> src)
            where T : unmanaged
                => ref As<T,byte>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort first<T>(W16 w, Span<T> src)
            where T : unmanaged
                => ref As<T,ushort>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint first<T>(W32 w, Span<T> src)
            where T : unmanaged
                => ref As<T,uint>(ref GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong first<T>(W64 w, Span<T> src)
            where T : unmanaged
                => ref As<T,ulong>(ref GetReference(src));
    }
}