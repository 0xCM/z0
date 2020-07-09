//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial class RootLegacy
    {
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Add(ref edit(in src), count); 

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref skip(in As.first(src), count);
    }
}