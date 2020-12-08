//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    using NK = NumericKind;

    partial class NumericKinds
    {
        /// <summary>
        /// Determines whether a numeric kind designates an unsigned integral type
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline), Op]
        public static bool unsigned(NumericKind k)
            => (k & NK.Unsigned) != 0;

        /// <summary>
        /// Returns true if a parametric type is of unsigned numeric type, false otherwise
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool unsigned<T>()
            where T : unmanaged
                => typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(ulong);

        /// <summary>
        /// Returns true if a type is of unsigned numeric type, false otherwise
        /// </summary>
        [MethodImpl(Inline), Op]
        public static bool unsigned(Type src)
            => src == typeof(byte)
            || src == typeof(ushort)
            || src == typeof(uint)
            || src == typeof(ulong);

        /// <summary>
        /// Returns true if a value is of unsigned numeric type, false otherwise
        /// </summary>
        [MethodImpl(Inline), Op]
        public static bool unsigned(object src)
            => src is byte || src is ushort || src is uint || src is ulong;

        /// <summary>
        /// Recognized unsigned integral types
        /// </summary>
        [Op]
        public static IEnumerable<Type> UnsignedTypes()
            => seq(typeof(byte), typeof(ushort),  typeof(uint), typeof(ulong));

        /// <summary>
        /// Recognized unsigned integral kinds
        /// </summary>
        [Op]
        public static IEnumerable<NumericKind> UnsignedKinds()
            => seq(NK.U8, NK.U16, NK.U32, NK.U64);
    }
}