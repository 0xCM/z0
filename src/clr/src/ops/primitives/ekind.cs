//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ClrPrimitives
    {
        [Op]
        public static ClrEnumKind ekind(Type e)
        {
            var tc = Type.GetTypeCode(e.GetEnumUnderlyingType());
            return (ClrEnumKind)kind(tc);
        }

        [MethodImpl(Inline)]
        public static ClrEnumKind ekind<E>(E e = default)
            where E : unmanaged, Enum, IEquatable<E>
                => ekind(typeof(E));

        [MethodImpl(Inline)]
        public static unsafe E ekind<E,T>(T v)
            where E : unmanaged, Enum, IEquatable<E>
            where T : unmanaged, IEquatable<T>
                => Unsafe.Read<E>((E*)&v);
    }
}