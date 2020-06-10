//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Enums
    {
        /// <summary>
        /// Interprets an enum value as a signed byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte e8i<E>(E e = default)
            where E : unmanaged, Enum
                => Control.e8i(e);

        /// <summary>
        /// Interprets an enum value as a byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte e8u<E>(E e)
            where E : unmanaged, Enum
                => Control.e8u(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ushort e16u<E>(E e)
            where E : unmanaged, Enum
                => Control.e16u(e);

        /// <summary>
        /// Interprets an enum value as a signed 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static short e16i<E>(E e)
            where E : unmanaged, Enum
                => Control.e16i(e);

        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static int e32i<E>(E e)
            where E : unmanaged, Enum
                => Control.e32i(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static uint e32u<E>(E e)
            where E : unmanaged, Enum
                => Control.e32u(e);

        /// <summary>
        /// Interprets an enum value as a signed 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static long e64i<E>(E e)
            where E : unmanaged, Enum
                => Control.e64i(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ulong e64u<E>(E e)
            where E : unmanaged, Enum
                => Control.e64u(e);
    }
}