//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    static class GenericMethodCases
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T and<T>(T a, T b)
            where T : unmanaged
                => gmath.and(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T or<T>(T a, T b)
            where T : unmanaged
                => gmath.or(a,b);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T xor<T>(T a, T b)
            where T : unmanaged
                => gmath.xor(a,b);
    }
}