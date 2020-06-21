//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct Imagine
    {
        /// <summary>
        /// Covers a pointer-identified T-counted buffer a readonly span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="count">The number of bytes to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> cover<T>(T* pSrc, int count)
            where T : unmanaged
                => CreateSpan(ref @ref<T>(pSrc), count);

        /// <summary>
        /// Covers a reference-identified T-counted buffer with a readonly span
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The number of T-cells to cover</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cover<T>(in T src, int count)
            => CreateReadOnlySpan(ref edit(src), count);    


    }
}