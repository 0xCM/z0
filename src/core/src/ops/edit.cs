//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct core
    {
        /// <summary>
        /// Transforms a readonly T-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T edit<T>(in T src)
            => ref AsRef(src);

        /// <summary>
        /// Transforms a readonly S-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src)
            => ref As<S,T>(ref AsRef(src));

        /// <summary>
        /// Transforms a readonly S-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src, ref T dst)
            => ref As<S,T>(ref AsRef(src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte edit<T>(W8 w, in T src)
            => ref As<T,byte>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort edit<T>(W16 w, in T src)
            => ref As<T,ushort>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint edit<T>(W32 w, in T src)
            => ref As<T,uint>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong edit<T>(W64 w, in T src)
            => ref As<T,ulong>(ref AsRef(in src));

        /// <summary>
        /// Covers the content of a readonly span with an editable span
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <returns>Obviously, this trick could be particularly dangerous</returns>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> edit<T>(ReadOnlySpan<T> src)
            => cover(edit(first(src)), src.Length);

        /// <summary>
        /// Covers a memory segment with a span
        /// </summary>
        /// <param name="src">The base address</param>
        /// <param name="size">The segment size, in bytes</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(MemoryAddress src, ByteSize size)
            => cover<byte>(src.Ref<byte>(), size);
    }
}