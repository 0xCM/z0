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
    }
}