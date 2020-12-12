//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

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
            => alg.hash(src);

        /// <summary>
        /// Creates a 64-bit hash code predicated on two types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash(Type x, Type y)
            => alg.hash(x,y);

        /// <summary>
        /// Creates a 64-bit hash code predicated on three types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash(Type t1, Type t2, Type t3)
            => alg.hash(t1, t2, t3);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint hash<T>(Vector128<T> src)
            where T : unmanaged
                => alg.hash(src);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint hash(sbyte x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint hash(byte x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(short x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ushort x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(int x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(uint x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ulong x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(long x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(char x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(float x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(double x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(decimal x)
            => alg.hash(x);

        /// <summary>
        /// Creates an unsigned hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(bool x)
            => alg.hash(x);

        [MethodImpl(Inline), Op]
        public static unsafe uint hash(string src)
            => alg.hash(src);

        /// <summary>
        /// Calculates a combined hash for 2 unsigned 32-bit integers
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(uint x, uint y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(sbyte x, sbyte y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(byte x, byte y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(short x, short y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ushort x, ushort y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(int x, int y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(ulong x, ulong y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(long x, long y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(float x, float y)
            => alg.hash(x, y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(double x, double y)
            => alg.hash(x,y);

        /// <summary>
        /// Creates a combined/unsigned hash code
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static uint hash(decimal x, decimal y)
            => alg.hash(x,y);

        /// <summary>
        /// Creates a 64-bit hashcode over a pair
        /// </summary>
        /// <param name="x">The first member</param>
        /// <param name="y">The second member</param>
        /// <typeparam name="X">The first member type</typeparam>
        /// <typeparam name="Y">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash64<X,Y>(X x, Y y)
            => alg.hash64(x,y);

        /// <summary>
        /// Creates a 32-bit hash code predicated on a type parameter
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static uint hash<T>()
            => alg.hash<T>();

        /// <summary>
        /// Creates a 64-bit hash code predicated on two type parameters
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash<S,T>()
            => alg.hash<S,T>();

        /// <summary>
        /// Computes hash codes for unmanaged system primitives
        /// </summary>
        /// <param name="src">The primal value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(T src)
            => alg.hash(src);

        /// <summary>
        /// Computes a combined hash code for a pair
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(T x, T y)
            => alg.hash(x,y);
    }
}