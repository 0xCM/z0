//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static int ihash(sbyte x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static int ihash(byte x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(short x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(ushort x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(int x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(uint x)
            => (int)x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(ulong x)
            => (int)hash(x,(x >> 32));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(long x)
            => (int)hash(x,(x >> 32));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(char x)
            => x;

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(float x)
            => ihash((long)x);

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(double x)
            => ihash(@ulong(x));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(decimal x)
            => ihash(@ulong(x));

        /// <summary>
        /// Creates a signed hash code
        /// </summary>
        /// <param name="x">The source value</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int ihash(bool x)
            => @byte(x);
    }
}