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
        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly Block128<T> abs<T>(in Block128<T> a, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly Block256<T> abs<T>(in Block256<T> a, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w256).Invoke(a, dst);
    }
}