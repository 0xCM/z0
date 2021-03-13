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
        public static bit eq<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.eq(a.Scalar, b.Scalar);

        /// <summary>
        /// Determines equality between an enum literal and an integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit eq<E>(E e1, E e2)
            where E : unmanaged, Enum
        {
            if(size<E>() == 1)
                return math.eq(uint8(e1), uint8(e2));
            else if(size<E>() == 2)
                return math.eq(uint16(e1), uint16(e2));
            else if(size<E>() == 4)
                return math.eq(uint32(e1), uint32(e2));
            else
                return math.eq(uint64(e1), uint64(e2));
        }

        /// <summary>
        /// Determines equality between an enum literal and an integral scalar value
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit same<E,T>(E e, T s)
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
        public static bit same<E,T>(T s, E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.eq(@as<E,T>(e), s);
    }
}