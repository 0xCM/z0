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
        public static Span<bit> testz<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
                => BSvc.testz<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<bit> testz<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
                => BSvc.testz<T>(w256).Invoke(a, b, dst);
    }
}