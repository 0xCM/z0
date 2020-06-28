//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static OpacityKind;
    
    partial struct sys
    {
        [MethodImpl(Options), Opaque(SpanToArray), Closures(Closure)]
        public static T[] array<T>(Span<T> src)
            => src.ToArray();
    }
}