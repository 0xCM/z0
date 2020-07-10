//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    partial struct sys
    {
        [MethodImpl(Options), Op, Closures(Closure)]
        public static ref readonly Span<T> clear<T>(in Span<T> src)
            => ref proxy.clear(src);
    }
}