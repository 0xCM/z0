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
        [MethodImpl(Options), Opaque(ClearSpan), Closures(Closure)]
        public static Span<T> clear<T>(Span<T> src)
        {
            src.Clear();
            return src;
        }
    }
}