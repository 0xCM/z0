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
        
    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> v256<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
                => Vector256.WithUpper(Vector256.WithLower(default,a),b);
    }
}