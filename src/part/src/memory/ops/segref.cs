//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static Ref segref(MemoryAddress address, ByteSize size)
            => new Ref(address, size);

        /// <summary>
        /// Captures a parametric reference to cell content beginning at a specified address
        /// </summary>
        /// <param name="src">The content address</param>
        /// <param name="count">The content cell count</param>
        /// <typeparam name="T">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<T> segref<T>(MemoryAddress address, Count count)
            where T : unmanaged
                => new Ref<T>(address, size<T>(count));

        /// <summary>
        /// Captures a sized readonly parametric reference to source span content
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> segref<T>(ReadOnlySpan<T> src)
            => new Ref<T>(memory.segref(pvoid(first(src)), size<T>((uint)src.Length)));

        /// <summary>
        /// Captures a character segment over source string content
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe Ref<char> segref(string src)
            => new Ref<char>(new Ref(address(src), (uint)src.Length*2));

        /// <summary>
        /// Captures a segment reference
        /// </summary>
        /// <param name="src">The leading cell</param>
        /// <param name="count">The covered cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<T> segref<T>(in T src, uint count)
            => new Ref(address(src), count*size<T>());

        /// <summary>
        /// Captures a segment reference
        /// </summary>
        /// <param name="src">The leading cell</param>
        /// <param name="count">The covered cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> segref<T>(in T src, int count)
            => new Ref<T>(segref(pvoid(src), size<T>((uint)count)));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> segref<T>(T* pSrc, ByteSize size)
            where T : unmanaged
                => new Ref<T>(pSrc, size);

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline), Op]
        public static unsafe Ref segref(void* pSrc, uint size)
            => new Ref((ulong)pSrc, size);

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="src">The reference address</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline), Op]
        public static Ref segref(MemoryAddress src, uint size)
            => new Ref(src, size);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> segref<T>(T[] src)
            => segref(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref<sbyte> segref(sbyte[] src)
            => segref(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref<byte> segref(byte[] src)
            => segref(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref<ulong> segref(ulong[] src)
            => segref(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> segref<T>(Span<T> src)
            => new Ref<T>(pvoid(first(src)), size<T>((uint)src.Length));
    }
}