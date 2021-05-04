//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct emath
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> div<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(gmath.div(a.Scalar, b.Scalar));
    }
}