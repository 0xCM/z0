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