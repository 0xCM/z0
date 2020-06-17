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
    using static Memories;

    partial class Blocks
    {
        /// <summary>
        /// Loads a specified count of 8-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block8<T> load<T>(W8 w, ref T src, int count)
            where T : unmanaged
                => new Block8<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));

        /// <summary>
        /// Loads a single 16-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block16<T> load<T>(W16 w, ref T src)
            where T : unmanaged
                => new Block16<T>(MemoryMarshal.CreateSpan(ref src, length<T>(w)));

        /// <summary>
        /// Loads a specified count of 16-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block16<T> load<T>(W16 w, ref T src, int count)
            where T : unmanaged
                => new Block16<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));

        /// <summary>
        /// Loads a single 32-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block32<T> load<T>(W32 w, ref T src)
            where T : unmanaged
                => new Block32<T>(MemoryMarshal.CreateSpan(ref src, length<T>(w)));

        /// <summary>
        /// Loads a specified count of 32-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block32<T> load<T>(W32 w, ref T src, int count)
            where T : unmanaged
                => new Block32<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));

        /// <summary>
        /// Loads a single 64-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block64<T> load<T>(W64 w, ref T src)
            where T : unmanaged
                => new Block64<T>(MemoryMarshal.CreateSpan(ref src, length<T>(w)));

        /// <summary>
        /// Loads a specified count of 64-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block64<T> load<T>(W64 w, ref T src, int count)
            where T : unmanaged
                => new Block64<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));

        /// <summary>
        /// Loads a single 128-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block128<T> load<T>(W128 w, ref T src)
            where T : unmanaged
                => new Block128<T>(MemoryMarshal.CreateSpan(ref src, length<T>(w)));

        /// <summary>
        /// Loads a specified count of 128-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block128<T> load<T>(W128 w, ref T src, int count)
            where T : unmanaged
                => new Block128<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));

        /// <summary>
        /// Loads a single 256-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block256<T> load<T>(W256 w, ref T src)
            where T : unmanaged
                => new Block256<T>(new Span<T>(constptr(in src), length<T>(w)));

        /// <summary>
        /// Loads a specified count of 256-bit block sfrom a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block256<T> load<T>(W256 w, ref T src, int count)
            where T : unmanaged
                => new Block256<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));
 
        /// <summary>
        /// Loads a single 512-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block512<T> load<T>(W512 w, ref T src)
            where T : unmanaged
                => new Block512<T>(new Span<T>(constptr(in src), length<T>(w)));
 
        /// <summary>
        /// Loads a specified count of 512-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Block512<T> load<T>(W512 w, ref T src, int count)
            where T : unmanaged
                => new Block512<T>(MemoryMarshal.CreateSpan(ref src, count*length<T>(w)));
 
    }
}