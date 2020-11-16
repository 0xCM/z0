//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("literals.typed", true)]
    public readonly struct TypedLiterals
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool eq<T>(TypedLiteralType<T> a, TypedLiteralType<T> b)
            => object.Equals(a.LiteralValue, b.LiteralValue);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(TypedLiteralType<T> src)
            => src.LiteralValue?.ToString() ?? EmptyString;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TypedLiteralType<T> type<T>(T value)
            => new TypedLiteralType<T>(value, LiteralKinds.kind<T>());

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E}'/>
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <typeparam name="E">The enumeration type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E> define<E>(E e)
            where E : unmanaged
                => new TypedLiteral<E>(e);

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E,T}'/>
        /// </summary>
        /// <param name="value">The numeric value</param>
        /// <param name="t">The primitive value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,T> define<E,T>(T value)
            where E : unmanaged
            where T : unmanaged
                => new TypedLiteral<E,T>(@class<E,T>(value), value);

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E,T}'/>
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,T> define<E,T>(E e)
            where E : unmanaged
            where T : unmanaged
                => new TypedLiteral<E,T>(e, value<E,T>(e));

        /// <summary>
        /// Creates a <see cref='TypedLiteral{E,T}'/>
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="t">The corresponding primitive value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,T> define<E,T>(E e, T t)
            where E : unmanaged, Enum
            where T : unmanaged
                => new TypedLiteral<E,T>(e,t);

        [MethodImpl(Inline)]
        internal static unsafe V value<E,V>(E @class)
            where E : unmanaged
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&@class));

        [MethodImpl(Inline)]
        internal static unsafe E @class<E,V>(V v)
            where E : unmanaged
            where V : unmanaged
                => Unsafe.Read<E>((E*)&v);
    }
}