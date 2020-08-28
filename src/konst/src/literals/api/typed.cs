//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Literals
    {
        /// <summary>
        /// Creates a <see cref='TypedLiteral{E}'/>
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <typeparam name="E">The enumeration type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E> typed<E>(E e)
            where E : unmanaged, Enum
                => new TypedLiteral<E>(e);

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E,T}'/>
        /// </summary>
        /// <param name="value">The numeric value</param>
        /// <param name="t">The primitive value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,T> typed<E,T>(T value)
            where E : unmanaged, Enum
            where T : unmanaged
                => new TypedLiteral<E,T>(eval<E,T>(value), value);

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E,T}'/>
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,T> typed<E,T>(E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => new TypedLiteral<E,T>(e, numeric<E,T>(e));

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E,T}'/>
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="t">The corresponding primitive value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,T> typed<E,T>(E e, T t)
            where E : unmanaged, Enum
            where T : unmanaged
                => new TypedLiteral<E,T>(e,t);
    }
}