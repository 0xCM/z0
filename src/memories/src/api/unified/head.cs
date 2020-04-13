//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(Span<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a reference to the head of a span, offset by a specified amount
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(Span<T> src, int offset)
            => ref Unsafe.Add(ref head(src), offset);        

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the head of a readonly span, offset by a specified amount
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src, int offset)
            where T : unmanaged
                => ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);                

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(T[] src)
            => ref MemoryMarshal.GetReference<T>(src);
   }
}