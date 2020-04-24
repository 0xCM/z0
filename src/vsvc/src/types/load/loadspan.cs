//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; 
    using static Memories;

    partial class VSvcHosts
    {
        public readonly struct LoadSpan128<T> : ISVFSpanLoad128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(ReadOnlySpan<T> x, int offset) 
                => Vectors.vload(n128,x,offset);            
        }

        public readonly struct LoadSpan256<T> : ISVFSpanLoad256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(ReadOnlySpan<T> x, int offset) 
                => Vectors.vload(n256,x,offset);
        }
    }
}