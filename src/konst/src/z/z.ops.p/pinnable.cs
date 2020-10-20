// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Returns a pinnable reference to the leading cell of a specified <see cref='Span{T}'/>
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
		[MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T pinnable<T>(Span<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a pinnable reference to the leading cell of a specified <see cref='ReadOnlySpan{T}'/>
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
		[MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T pinnable<T>(ReadOnlySpan<T> src)
            => ref MemoryMarshal.GetReference<T>(src);
    }
}