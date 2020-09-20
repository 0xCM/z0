//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static Refinement<V,T> refine<V,T>(V src, T t = default)
            where V : unmanaged, Enum
            where T : unmanaged
                => new Refinement<V,T>(src);
    }
}