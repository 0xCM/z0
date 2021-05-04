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
    using static ClrEnums;

    partial struct emath
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> sll<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(gmath.sll(a.Scalar, count));

        [MethodImpl(Inline)]
        public static uint sll<E>(bit src, E offset)
            where E : unmanaged, Enum
                => gmath.sll((uint)src, @as<E,byte>(offset));

        [MethodImpl(Inline)]
        public static T sll<T,E>(T src, E offset)
            where T : unmanaged
            where E : unmanaged, Enum
                => gmath.sll(src, ClrEnums.scalar<E,byte>(offset));


        [MethodImpl(Inline)]
        public static T sll<E,T>(E src, byte count)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.sll(scalar<E,T>(src),count);

        /// <summary>
        /// Converts a source enume value src:E to a parametrically-identified numeric type S,
        /// shifts the converted value to the left a specified number of bits then converts
        /// the outcome of this computation to a numeric type T
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="count">The nuumber of bits to shift</param>
        /// <param name="s">A representative for the numeric source</param>
        /// <param name="t">A representative for the numeric target</param>
        /// <typeparam name="E">The source enum type</typeparam>
        /// <typeparam name="S">The source numeric type</typeparam>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T sll<E,S,T>(E src, byte count)
            where E : unmanaged, Enum
            where S : unmanaged
            where T : unmanaged
                => Numeric.force<S,T>(gmath.sll(ClrEnums.scalar<E,S>(src), count));

        /// <summary>
        /// Converts a source enume value src:E to a parametrically-identified numeric type S,
        /// shifts the converted value to the left a specified number of bits then converts
        /// the outcome of this computation to a numeric type T
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="count">The number of bits to shift</param>
        /// <param name="s">A representative for the numeric source</param>
        /// <param name="t">A representative for the numeric target</param>
        /// <typeparam name="E">The source enum type</typeparam>
        /// <typeparam name="C">The shift count enum type, which must have an underlying type of byte</typeparam>
        /// <typeparam name="S">The source numeric type</typeparam>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T sll<E,C,S,T>(E src, C count)
            where E : unmanaged, Enum
            where C : unmanaged, Enum
            where S : unmanaged
            where T : unmanaged
                => Numeric.force<S,T>(gmath.sll(scalar<E,S>(src), scalar<C,byte>(count)));

    }
}