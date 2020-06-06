//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class XTend
    {
       [MethodImpl(Inline)]
        public static void Iteri<T>(this Span<T> src, Action<int,T> f)
            => Spans.iteri(src,f);

        [MethodImpl(Inline)]
        public static void Iter<T>(this Span<T> src, Action<T> f)
            => Spans.iter(src,f); 
    }
}