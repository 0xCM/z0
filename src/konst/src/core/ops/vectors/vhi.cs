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
        
    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong vhi<T>(Vector128<T> src)
            where T : unmanaged
                => vcell(v64u(src),1);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vhi<T>(Vector256<T> src)
            where T : unmanaged
                => Vector256.GetUpper(src);
        
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vhi<T>(Vector512<T> src)
            where T : unmanaged
                => src.Hi;
    }
}