//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Fixed128V ToFixedV<T>(this Vector128<T> x)
            where T : unmanaged
                => Fixed128V.From(x);

        [MethodImpl(Inline)]
        public static Fixed256V ToFixedV<T>(this Vector256<T> x)
            where T : unmanaged
                => Fixed256V.From(x);
    }
}