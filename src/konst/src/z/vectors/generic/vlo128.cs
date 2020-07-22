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
        public static Vector128<T> vlo128<T>(Vector256<T> src)
            where T : unmanaged
                => Vector256.GetLower(src);
    }
}