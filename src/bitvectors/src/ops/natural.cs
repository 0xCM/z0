//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class BitVector
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref T packseq<T>(ReadOnlySpan<byte> src, out T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                dst = z.generic<T>(packseq(src, out byte _));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                dst = z.generic<T>(packseq(src, out ushort _));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                dst = z.generic<T>(packseq(src, out uint _));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                dst = z.generic<T>(packseq(src, out ulong _));
            else
                throw no<T>();

            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 8 (or fewer) bytes from the source into a single byte
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline), Op]
        static ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
        {
            dst = 0;
            var count = math.min(8, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (byte)(1 << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 16 (or fewer) bytes from the source into an unsigned short
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline), Op]
        static ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
        {
            dst = 0;
            var count = math.min(16, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (ushort)(1 << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 32 (or fewer) bytes from the source into an unsigned int
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline), Op]
        static ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
        {
            dst = 0u;
            var count = math.min(32, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (1u << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 64 (or fewer) bytes from the source into an unsigned long
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline), Op]
        static ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
        {
            dst = 0ul;
            var count = math.min(64, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (1ul << i);
            return ref dst;
        }

        /// <summary>
        /// Defines a bitvector of natural width
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="a">The scalar source data</param>
        /// <typeparam name="N">The width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(N n, T a)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitVector<N, T>(a);

        /// <summary>
        /// Defines a 128-bit bitvector of natural width
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="a">The scalar source data</param>
        /// <typeparam name="N">The width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> natural<N,T>(N n, Vector128<T> x)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitVector128<N, T>(x);

        /// <summary>
        /// Defines a bitvector of natural width
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="a">The scalar source data</param>
        /// <typeparam name="N">The width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(T a)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitVector<N, T>(a);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(BitString src, N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => packseq(src.Slice(0, nat32i(n)).BitSeq, out T _);
    }

    static class BvUtil
    {

    }
}