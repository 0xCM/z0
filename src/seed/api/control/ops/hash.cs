//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        const uint K = 0xA5555529;
        
        const uint FnvOffsetBias = 2166136261;

        const uint FnvPrime = 16777619;

        /// <summary>
        /// Computes the FNV-1a hash of the source sequence
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="src">The data source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        static uint hash_ref(ReadOnlySpan<byte> src)
        {
            var hashCode = FnvOffsetBias;
            for (int i = 0; i < src.Length; i++)
                hashCode = (hashCode ^ skip(src,i)) * FnvPrime;
            return hashCode;
        }

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(uint x, uint y)
            => (y * K) + x;

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<sbyte> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<byte> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<short> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<ushort> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<int> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<uint> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<ulong> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        [MethodImpl(Inline), Op]
        public static uint hash(ReadOnlySpan<long> src)
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var x = FnvOffsetBias;
            for(var i=0; i<src.Length; i++)
                x = hash(x,skip(src,i)) * FnvPrime;
            return x;
        }

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(sbyte x, sbyte y)
            => hash((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(byte x, byte y)
            => hash((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(short x, short y)
            => hash((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ushort x, ushort y)
            => hash((uint)x,(uint)y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(int x, int y)
            => hash((uint)x, (uint)y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ulong x, ulong y)
            => hash(hash((uint)x,(uint)(x >> 32)), hash((uint)y,(uint)(y >> 32)));

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(long x, long y)
            => hash((ulong)x,(ulong)y);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(sbyte x)
            => hash((uint)x,0u);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(byte x)
            => hash((uint)x,0u);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(short x)
            => hash((uint)x,0u);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ushort x)
            => hash((uint)x,0u);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(int x)
            => hash((uint)x,0u);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(uint x)
            => hash((uint)x,0u);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ulong x)
            => hash((uint)x,(uint)(x >> 32));

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(long x)
            => hash((ulong)x);
    }
}