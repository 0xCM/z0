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
        public static @enum<E,T> and<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(gmath.and(a.Scalar, b.Scalar));

        [MethodImpl(Inline)]
        public static T and<E,T>(E a, E b, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.and(scalar<E,T>(a), scalar<E,T>(b));
    }
}