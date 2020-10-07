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
        public static ulong vlo<T>(Vector128<T> src)
            where T : unmanaged
                => vcell(v64u(src),0);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlo<T>(Vector256<T> src)
            where T : unmanaged
                => Vector256.GetLower(src);
        
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlo<T>(Vector512<T> src)
            where T : unmanaged
                => src.Lo;
    }
}