//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
        
    partial struct V0
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector512<T> v512<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => new Vector512<T>(a,b);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector512<T> v512<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c, Vector128<T> d)
            where T : unmanaged
                => new Vector512<T>(a,b,c,d);
    }
}