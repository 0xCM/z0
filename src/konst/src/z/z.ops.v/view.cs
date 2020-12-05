//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.InteropServices.MemoryMarshal;
    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)
            => ref memory.view<S,T>(src);

        [MethodImpl(Inline)]
        public static ref readonly sbyte view8i<T>(in T src)
            => ref memory.view8i(src);

        [MethodImpl(Inline)]
        public static ref readonly byte view8u<T>(in T src)
            => ref memory.view8u(src);

        [MethodImpl(Inline)]
        public static ref readonly short view16i<T>(in T src)
            => ref memory.view16i(src);

        [MethodImpl(Inline)]
        public static ref readonly ushort view16u<T>(in T src)
            => ref memory.view16u(src);

        [MethodImpl(Inline)]
        public static ref readonly int view32i<T>(in T src)
            => ref memory.view32i(src);

        [MethodImpl(Inline)]
        public static ref readonly uint view32u<T>(in T src)
            => ref memory.view32u(src);

        [MethodImpl(Inline)]
        public static ref readonly long view64i<T>(in T src)
            => ref memory.view64i(src);

        [MethodImpl(Inline)]
        public static ref readonly ulong view64u<T>(in T src)
            => ref memory.view64u(src);

        [MethodImpl(Inline)]
        public static ref readonly float view32f<T>(in T src)
            => ref memory.view32f(src);

        [MethodImpl(Inline)]
        public static ref readonly double view64f<T>(in T src)
            => ref memory.view64f(src);

        [MethodImpl(Inline)]
        public static ref readonly decimal view128f<T>(in T src)
            => ref memory.view128f(src);

        [MethodImpl(Inline)]
        public static ref readonly char view16c<T>(in T src)
            => ref memory.view16c(src);

        [MethodImpl(Inline)]
        public static ref readonly bool view1u<T>(in T src)
            => ref memory.view1u(src);

        /// <summary>
        /// Reveals the character data identified by a string reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> view(in StringRef src)
            => cover<char>(src.Address.Pointer<char>(), (uint)src.Length);

        /// <summary>
        /// Covers a memory reference with a readonly span
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(in MemorySegment src)
            => cover(src.Address.Ref<T>(), count<T>(src));

        /// <summary>
        /// Creates a T-span from a supplied reference
        /// </summary>
        /// <param name="src">A reference to the leading cell</param>
        /// <param name="count">The source cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(in T src, uint count)
            => CreateReadOnlySpan(ref edit(src), (int)count);

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