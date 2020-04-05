//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Seed;        

    partial class Blocks
    {
        /// <summary>
        /// Allocates a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> single<T>(W16 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> single<T>(W32 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> single<T>(W64 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 128-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> single<T>(W128 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> single<T>(W256 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);

        /// <summary>
        /// Allocates a single 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> single<T>(W512 w, T t = default)
            where T : unmanaged        
                => alloc<T>(w,1);  

        /// <summary>
        /// Loads a single 16-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> single<T>(W16 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, length<T>(w)));

        /// <summary>
        /// Loads a single 32-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> single<T>(W32 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, length<T>(w)));

        /// <summary>
        /// Loads a single 64-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> single<T>(W64 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, length<T>(w)));

        /// <summary>
        /// Loads a single 128-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> single<T>(W128 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, length<T>(w)));

        /// <summary>
        /// Loads a single 256-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> single<T>(W256 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, length<T>(w)));

        /// <summary>
        /// Loads a single 512-bit block from the leading elements of a source span (unchecked)
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> single<T>(W512 w, Span<T> src)
            where T : unmanaged        
                => unsafeload(w, src.Slice(0, length<T>(w)));
    }
}