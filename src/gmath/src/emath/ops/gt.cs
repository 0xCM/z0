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
        [MethodImpl(Inline)]
        public static bit gt<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.lt(a.Scalar, b.Scalar);

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

    }
}