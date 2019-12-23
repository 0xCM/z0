//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;
    using static nfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block16<T> unsafeload<T>(N16 w, Span<T> src)
            where T : unmanaged
                => new Block16<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block32<T> unsafeload<T>(N32 w, Span<T> src)
            where T : unmanaged
                => new Block32<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block64<T> unsafeload<T>(N64 w, Span<T> src)
            where T : unmanaged
                => new Block64<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block128<T> unsafeload<T>(N128 w, Span<T> src)
            where T : unmanaged
                => new Block128<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block256<T> unsafeload<T>(N256 w, Span<T> src)
            where T : unmanaged
                => new Block256<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block512<T> unsafeload<T>(N512 w, Span<T> src)
            where T : unmanaged
                => new Block512<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock16<T> unsafeload<T>(N16 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ConstBlock16<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock32<T> unsafeload<T>(N32 w,  ReadOnlySpan<T> src)
            where T : unmanaged
                => new ConstBlock32<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock64<T> unsafeload<T>(N64 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ConstBlock64<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock128<T> unsafeload<T>(N128 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ConstBlock128<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock256<T> unsafeload<T>(N256 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ConstBlock256<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock512<T> unsafeload<T>(N512 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ConstBlock512<T>(src);
    }

}