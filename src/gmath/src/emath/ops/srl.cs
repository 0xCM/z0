//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Enums;

    partial struct emath
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> srl<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(gmath.srl(a.Scalar, count));


        [MethodImpl(Inline)]
        public static T srl<E,T>(E src, byte count, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.srl(scalar<E,T>(src),count);
    }
}