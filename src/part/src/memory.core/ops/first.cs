//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct memory
    {
        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(Span<T> src)
            => ref GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first source cell
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly char first(ReadOnlySpan<char> src)
            => ref GetReference(src);

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T first<T>(ReadOnlySpan<T> src)
            => ref GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first cell of a readonly span, offset by a specified cell count
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The cell-measured offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T first<T>(ReadOnlySpan<T> src, int offset)
            where T : unmanaged
                => ref Add(ref GetReference<T>(src), offset);
    }
}