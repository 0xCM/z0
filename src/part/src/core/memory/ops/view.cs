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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, int count)
            where T : unmanaged
                => cover<T>(src.Ref<T>(), (uint)count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(MemoryAddress src, uint count)
            where T : unmanaged
                => cover<T>(src.Ref<T>(), count);

        /// <summary>
        /// Covers a memory reference with a readonly span
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(MemorySegment src)
            => cover(src.BaseAddress.Ref<T>(), count<T>(src));

        /// <summary>
        /// Covers a memory segment with a span
        /// </summary>
        /// <param name="src">The base address</param>
        /// <param name="size">The segment size, in bytes</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(MemoryAddress src, ByteSize size)
            => cover<byte>(src.Ref<byte>(), size);

        /// <summary>
        /// Covers a <see cref='MemoryRange'/> with a readonly span
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(MemoryRange src)
            => cover(src.Min.Ref<T>(), cells<T>(src));

        /// <summary>
        /// Presents a readonly S-reference as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));

        /// <summary>
        /// Interprets a readonly T-reference as a readonly bool reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly bool view1u<T>(in T src)
            => ref view<T,bool>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly byte view<T>(W8 w, in T src)
            => ref view<T,byte>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ushort view<T>(W16 w, in T src)
            => ref view<T,ushort>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint view<T>(W32 w, in T src)
            => ref view<T,uint>(src);

        /// <summary>
        /// Presents a readonly T-reference as a reference of bit-width w
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ulong view<T>(W64 w, in T src)
            => ref view<T,ulong>(src);
    }
}