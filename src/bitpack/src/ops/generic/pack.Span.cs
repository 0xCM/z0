//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    using static Memories;
 
    partial class BitPack
    {
        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static byte pack<T>(ReadOnlySpan<T> src, N8 count, N8 mod, int offset = 0)
            where T : unmanaged
                => pack8(uint64(skip(src,offset)));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort pack<T>(ReadOnlySpan<T> src, N16 count, N8 mod, int offset = 0)
            where T : unmanaged
                => pack(skip(src,offset), count, mod);

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint pack<T>(ReadOnlySpan<T> src, N32 count, N8 mod, int offset = 0)
            where T : unmanaged
                => pack(skip(src,offset), count, mod);

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        /// <param name="mod">The selection modulus</param>
        /// <param name="offset">The source offset</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong pack<T>(ReadOnlySpan<T> src, N64 count, N8 mod, int offset = 0)
            where T : unmanaged
                => pack(skip(src,offset),count,mod);        

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
        public static T pack<S,T>(ReadOnlySpan<S> src, N8 mod,  int offset, T t = default)
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
                return generic<T>(pack(src, n8, n8, offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack(src, n16, n8, offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack(src, n32, n8, offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack(src, n32, n8, offset));
            else
                return pack_i(src, mod,offset,t);
        }

        [MethodImpl(Inline)]
        static T pack_i<S,T>(ReadOnlySpan<S> src, N8 mod, int offset, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(pack(src, n8, n8, offset));
            else if(typeof(T) == typeof(short))
                return convert<T>(pack(src, n16, n8, offset));
            else if(typeof(T) == typeof(int))
                return convert<T>(pack(src, n32, n8, offset));
            else if(typeof(T) == typeof(long))
                return convert<T>(pack(src, n32, n8, offset));
            else
                throw Unsupported.define<T>();
        }
    }
}