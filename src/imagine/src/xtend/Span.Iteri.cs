//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class XTend
    {
       [MethodImpl(Inline)]
        public static void Iteri<T>(this Span<T> src, Action<int,T> f)
            => Z0.As.iteri(src,f);

        [MethodImpl(Inline)]
        public static void Iter<T>(this Span<T> src, Action<T> f)
            => Z0.As.iter(src,f); 
    }
}