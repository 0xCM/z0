//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static OpacityApiClass;

    partial struct proxy
    {
        [MethodImpl(Options), Opaque(ClearSpan), Closures(Closure)]
        public static ref readonly Span<T> clear<T>(in Span<T> src)
        {
            src.Clear();
            return ref src;
        }
    }
}