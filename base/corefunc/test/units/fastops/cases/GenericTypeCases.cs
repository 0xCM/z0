//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;

    [PrimalClosures(NumericKind.Integers)]
    class GenericTypeCases<T>
        where T : unmanaged
    {
        [MethodImpl(Inline), Op]
        public static T and(T a, T b)
            => gmath.and(a,b);

        [MethodImpl(Inline), Op]
        public static T or(T a, T b)
            => gmath.or(a,b);

        [MethodImpl(Inline), Op]
        public static T xor(T a, T b)
            => gmath.xor(a,b);

    }
}