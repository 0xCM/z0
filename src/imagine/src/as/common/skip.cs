//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial struct AsInternal
    {
        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref add(first(src), count);            
    }
}