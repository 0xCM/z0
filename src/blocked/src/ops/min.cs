//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst; 
    using static z;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> min<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.min<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> min<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.min<T>(w256).Invoke(a, b, dst);
    }
}