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
    using static z;

    partial struct BufferBlocks
    {
        /// <summary>
        /// Loads a specified count of 8-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock8<T> load<T>(W8 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock8<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 16-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock16<T> load<T>(W16 w, ref T src)
            where T : unmanaged
                => new SpanBlock16<T>(MemoryMarshal.CreateSpan(ref src, blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 16-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock16<T> load<T>(W16 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock16<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 32-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock32<T> load<T>(W32 w, ref T src)
            where T : unmanaged
                => new SpanBlock32<T>(MemoryMarshal.CreateSpan(ref src, blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 32-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock32<T> load<T>(W32 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock32<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 64-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock64<T> load<T>(W64 w, ref T src)
            where T : unmanaged
                => new SpanBlock64<T>(MemoryMarshal.CreateSpan(ref src, blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 64-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock64<T> load<T>(W64 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock64<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 128-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock128<T> load<T>(W128 w, ref T src)
            where T : unmanaged
                => new SpanBlock128<T>(MemoryMarshal.CreateSpan(ref src, blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 128-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock128<T> load<T>(W128 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock128<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 256-bit block from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock256<T> load<T>(W256 w, ref T src)
            where T : unmanaged
                => new SpanBlock256<T>(new Span<T>(gptr(src), blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 256-bit block sfrom a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock256<T> load<T>(W256 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock256<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

        /// <summary>
        /// Loads a single 512-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock512<T> load<T>(W512 w, ref T src)
            where T : unmanaged
                => new SpanBlock512<T>(new Span<T>(gptr(src), blocklength<T>(w)));

        /// <summary>
        /// Loads a specified count of 512-bit blocks from a reference
        /// </summary>
        /// <param name="w">The target block width</param>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The blocked data type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe SpanBlock512<T> load<T>(W512 w, ref T src, int count)
            where T : unmanaged
                => new SpanBlock512<T>(MemoryMarshal.CreateSpan(ref src, count*blocklength<T>(w)));

    }
}