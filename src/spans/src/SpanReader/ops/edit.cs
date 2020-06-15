//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct SpanReader
    {
        [MethodImpl(Inline)]
        public ref T edit<T>(in T src)
            => ref Unsafe.AsRef(in src);
    }
}