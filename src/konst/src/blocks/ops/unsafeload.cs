//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;            

    using static Konst;        

    partial struct Blocks
    {
        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt8k)]
        internal static Block8<T> unsafeload<T>(W8 w, Span<T> src)
            where T : unmanaged
                => new Block8<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt16k)]
        internal static Block16<T> unsafeload<T>(W16 w, Span<T> src)
            where T : unmanaged
                => new Block16<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt32k)]
        internal static Block32<T> unsafeload<T>(W32 w, Span<T> src)
            where T : unmanaged
                => new Block32<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt32k)]
        internal static Block64<T> unsafeload<T>(W64 w, Span<T> src)
            where T : unmanaged
                => new Block64<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt32k)]
        public static Block128<T> unsafeload<T>(W128 w, Span<T> src)
            where T : unmanaged
                => new Block128<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt32k)]
        internal static Block256<T> unsafeload<T>(W256 w, Span<T> src)
            where T : unmanaged
                => new Block256<T>(src);

        /// <summary>
        /// Loads a span into a blocked container without checks
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Load, Closures(UInt32k)]
        internal static Block512<T> unsafeload<T>(W512 w, Span<T> src)
            where T : unmanaged
                => new Block512<T>(src);
    }
}