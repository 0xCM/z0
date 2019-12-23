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
        /// Allocates a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> single<T>(N16 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> single<T>(N32 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> single<T>(N64 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 128-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> single<T>(N128 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> single<T>(N256 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> single<T>(N512 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);  

        /// <summary>
        /// Loads a single 16-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> single<T>(N16 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single 32-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> single<T>(N32 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single 64-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> single<T>(N64 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single 128-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> single<T>(N128 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single 256-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> single<T>(N256 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single 512-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> single<T>(N512 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single readonly 16-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock16<T> single<T>(N16 w, ReadOnlySpan<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single readonly 32-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock32<T> single<T>(N32 w, ReadOnlySpan<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single readonly 64-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> single<T>(N64 w, ReadOnlySpan<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single readonly 128-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> single<T>(N128 w, ReadOnlySpan<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single readonly 256-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock256<T> single<T>(N256 w, ReadOnlySpan<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));

        /// <summary>
        /// Loads a single readonly 512-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock512<T> single<T>(N512 w, ReadOnlySpan<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, blocklen<T>(w)));
    }
}