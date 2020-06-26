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
    using static Memories;

    partial class VSvcHosts
    {
        public readonly struct LoadSpan128<T> : ISpanLoader128<T,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(ReadOnlySpan<T> x, int offset) 
                => V0.vload(n128,x,offset);            
        }

        public readonly struct LoadSpan256<T> : ISpanLoader256<T,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(ReadOnlySpan<T> x, int offset) 
                => V0.vload(n256,x,offset);
        }
    }
}