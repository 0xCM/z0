//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Literals
    {
        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op]
        public static NumericKind kind(BinaryLiteral src)
            => src.Data?.GetType()?.NumericKind() ?? NumericKind.None;

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static NumericKind kind<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => NumericKinds.kind<T>();

        [MethodImpl(Inline)]
        public static unsafe E kind<E,T>(T v)
            where E : unmanaged, Enum, IEquatable<E>
            where T : unmanaged, IEquatable<T>
                => Unsafe.Read<E>((E*)&v);

        [Op]
        public static EnumLiteralKind kind(Type e)
        {
            var tc = Type.GetTypeCode(e.GetEnumUnderlyingType());
            return (EnumLiteralKind)ClrPrimitives.kind(tc);
        }

        [MethodImpl(Inline)]
        public static EnumLiteralKind kind<E>(E e = default)
            where E : unmanaged, Enum, IEquatable<E>
                => kind(typeof(E));
    }
}