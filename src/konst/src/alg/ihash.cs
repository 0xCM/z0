//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace alg
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.Part;
    using static Z0.memory;

    public readonly struct ihash
    {
        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static int calc(sbyte x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static int calc(byte x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(short x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(ushort x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(int x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(uint x)
            => (int)x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(ulong x)
            => (int)hash.calc(x,(x >> 32));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(long x)
            => (int)hash.calc(x,(x >> 32));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(char x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(float x)
            => calc((long)x);

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(double x)
            => calc(@ulong(x));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(decimal x)
            => calc(@ulong(x));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int calc(bool x)
            => @byte(x);
    }
}