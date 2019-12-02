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

    partial class DataBlocks
    {
        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block16<T> load<T>(Span<T> src, N16 n)
            where T : unmanaged
                => new Block16<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block32<T> load<T>(Span<T> src, N32 n)
            where T : unmanaged
                => new Block32<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block64<T> load<T>(Span<T> src, N64 n)
            where T : unmanaged
                => new Block64<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block128<T> load<T>(Span<T> src, N128 n)
            where T : unmanaged
                => new Block128<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static Block256<T> load<T>(Span<T> src, N256 n)
            where T : unmanaged
                => new Block256<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock16<T> load<T>(ReadOnlySpan<T> src, N16 n)
            where T : unmanaged
                => new ConstBlock16<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock32<T> load<T>(ReadOnlySpan<T> src, N32 n)
            where T : unmanaged
                => new ConstBlock32<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock64<T> load<T>(ReadOnlySpan<T> src, N64 n)
            where T : unmanaged
                => new ConstBlock64<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock128<T> load<T>(ReadOnlySpan<T> src, N128 n)
            where T : unmanaged
                => new ConstBlock128<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The block width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        internal static ConstBlock256<T> load<T>(ReadOnlySpan<T> src, N256 n)
            where T : unmanaged
                => new ConstBlock256<T>(src);
    }

}