//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class TypedLiteral
    {
        /// <summary>
        /// Creates a typed literal from an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enumeration type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E> From<E>(E @class)
            where E : unmanaged, Enum
                => @class;
        
        /// <summary>
        /// Creates a numeric-parametric typed literal from a numeric value
        /// </summary>
        /// <param name="value">The numeric value</param>
        /// <param name="e">An enum representative to aid type inference</param>
        /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
        /// <typeparam name="V">The numeric type refined by the enum</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,V> From<E,V>(V value, E e = default)
            where E : unmanaged, Enum
            where V : unmanaged
                => new TypedLiteral<E,V>(literal<E,V>(value));

        /// <summary>
        /// Creates a numeric-parametric typed literal from an enumeration literal
        /// </summary>
        /// <param name="@class">The enum litera value</param>
        /// <param name="v">An numeric representative to aid type inference</param>
        /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
        /// <typeparam name="V">The numeric type refined by the enum</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,V> From<E,V>(E @class, V v = default)
            where E : unmanaged, Enum
            where V : unmanaged
                => new TypedLiteral<E,V>(@class);
    }
}