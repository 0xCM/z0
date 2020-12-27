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

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> view(MemoryAddress src, ByteSize size)
            => cover<byte>(src.Ref<byte>(), size);

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
        /// Interprets a readonly T-reference as a readonly float128 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly decimal view128f<T>(in T src)
             => ref view<T,decimal>(src);

        /// <summary>
        /// Interprets a readonly T-reference as a readonly bool reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly bool view1u<T>(in T src)
            => ref view<T,bool>(src);
    }
}