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
        public static bit nonz<E,T>(@enum<E,T> a)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.nonz(a.Scalar);
    }
}