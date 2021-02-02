//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct emath
    {
        /// <summary>
        /// Determines equality between an enum literal and an integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit eq<E,T>(E e, T s)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.eq(@as<E,T>(e), s);

        /// <summary>
        /// Determines equality between an enum literal and an integral scalar value
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <param name="e">The enum literal value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit eq<E,T>(T s, E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.eq(@as<E,T>(e), s);

        /// <summary>
        /// Determines whether the value represented by an enum literal is less than a specified integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit lt<E,T>(E e, T s)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.lt(@as<E,T>(e), s);

        /// <summary>
        /// Determines whether the value represented by an enum literal is less than or equal to a specified integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit lteq<E,T>(E e, T s)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.lteq(@as<E,T>(e), s);

        /// <summary>
        /// Determines whether the value represented by an enum literal is greater than a specified integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit gt<E,T>(E e, T s)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.gt(@as<E,T>(e), s);

        /// <summary>
        /// Determines whether the value represented by an enum literal is greater than or equal to a specified integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit gteq<E,T>(E e, T s)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.gt(@as<E,T>(e), s);


        /// <summary>
        /// Determines whether an integral value is less than a value represented by an enum literal
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit lt<E,T>(T s, E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.lt(s, @as<E,T>(e));

        /// <summary>
        /// Determines whether an integral value is less than or equal to a value represented by an enum literal
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit lteq<E,T>(T s, E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.lteq(s, @as<E,T>(e));

        /// <summary>
        /// Determines whether an integral value is greater than a value represented by an enum literal
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit gt<E,T>(T s, E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.gt(s, @as<E,T>(e));

        /// <summary>
        /// Determines whether an integral value is greater or equal to a value represented by an enum literal
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit gteq<E,T>(T s, E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.gt(s, @as<E,T>(e));

        /// <summary>
        /// Determines whether an integral value is greater or equal to a value represented by an enum literal
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit between<E,T>(T s, E e0, E e1)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.between(s, @as<E,T>(e0), @as<E,T>(e1));

        /// <summary>
        /// Determines whether an integral scalar value is equal to one of two enum values
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <param name="e0">The first enum value</param>
        /// <param name="e1">The second enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit oneof<E,T>(T s, E e0, E e1)
            where E : unmanaged, Enum
            where T : unmanaged
                => eq(e0, s) || eq(e1, s);
    }
}