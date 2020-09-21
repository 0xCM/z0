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

    partial struct z
    {
        /// <summary>
        /// Computes the FNV-1a hash of the source sequence
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="src">The data source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        const uint K = 0xA5555529;

        const uint FnvOffsetBias = 2166136261;

        const uint FnvPrime = 16777619;

        [MethodImpl(Inline), Op]
        public static uint hash(Type src)
            => (uint)src.MetadataToken;

        /// <summary>
        /// Creates a 64-bit hash code predicated on two types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash(Type t1, Type t2)
            => (ulong)hash(t1) | (ulong)hash(t2) << 32;

        /// <summary>
        /// Creates a 64-bit hash code predicated on three types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash(Type t1, Type t2, Type t3)
            => hash(t1,t2) ^ hash(t1, t3);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint hash(sbyte x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint hash(byte x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(short x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ushort x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(int x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(uint x)
            => (uint)x;

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
            => hash((uint)x,(uint)(x >> 32));

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(char x)
            => (uint)x;

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(float x)
            => hash((long)x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(double x)
            => hash(@ulong(x));

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(decimal x)
            => hash(@ulong(x));

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(bool x)
            => @byte(x);

        [MethodImpl(Inline), Op]
        public static uint hash(string src)
            => (uint)(src?.GetHashCode() ?? int.MaxValue);


        [MethodImpl(Inline), Op]
        public static unsafe uint hash2(string src)
            => (uint)(pchar2(src ?? EmptyString));

        /// <summary>
        /// Calculates a combined hash for 2 unsigned 32-bit integers
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(uint x, uint y)
            => (y * K) + x;

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
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(float x, float y)
            => hash(@int(x), @int(y));

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(double x, double y)
            => hash(@ulong(x), @ulong(y));

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(decimal x, decimal y)
            => hash(@ulong(x) ,@ulong(y));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint hash<T>(Vector128<T> src)
            where T : unmanaged
        {
            var v = v64u(src);
            return hash(vcell(v,0), vcell(v,1));
        }
    }
}