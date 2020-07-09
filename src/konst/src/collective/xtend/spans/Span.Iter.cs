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
        public static void Iter<T>(this Span<T> src, Action<T> f)
            => core.iter(src,f); 
    }
}