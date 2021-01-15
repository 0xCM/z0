//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitPack
    {
        /// <summary>
        /// Packs bitsize[T] values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="offset">The source offset</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T pack<S,T>(ReadOnlySpan<S> src, N8 mod, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
                => pack_u(src, mod, offset,t);

        /// <summary>
        /// Packs bitsize[T] values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="offset">The source offset</param>
        /// <param name="t">A target type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T pack<S,T>(Span<S> src, N8 mod, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
                => pack_u(src.ReadOnly(), mod, offset,t);

        [MethodImpl(Inline)]
        static T pack_u<S,T>(ReadOnlySpan<S> src, N8 mod, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack8x8x1(src, n8, n8, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack16x8x1(src, n16, n8, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack32x8x1(src, n32, n8, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack64x8x1(src, n64, n8, offset));
            else
                return pack_i(src, mod, offset,t);
        }

        [MethodImpl(Inline)]
        static T pack_i<S,T>(ReadOnlySpan<S> src, N8 mod, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(pack8x8x1(src, n8, n8, offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(pack16x8x1(src, n16, n8, offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(pack32x8x1(src, n32, n8, offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(pack64x8x1(src, n64, n8, offset));
            else
                throw no<T>();
        }
    }
}