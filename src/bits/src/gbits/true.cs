//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class gbits
    {
        [MethodImpl(Inline), True, Closures(Integers)]
        public static T @true<T>()
            where T:unmanaged
                => Numeric.ones<T>();

        [MethodImpl(Inline), True, Closures(Integers)]
        public static T @true<T>(T a)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline), True, Closures(Integers)]
        public static T @true<T>(T a, T b)
            where T:unmanaged
                => @true<T>();
    }
}