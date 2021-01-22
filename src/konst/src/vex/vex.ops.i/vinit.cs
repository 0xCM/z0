//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vinit<T>(W128 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vinit<T>(W256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector512<T> vinit<T>(W512 w)
            where T : unmanaged
                => default;
    }
}