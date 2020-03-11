//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
        
    public static class OpIndexX
    {
        public static OpIndex<M> ToOpIndex<M>(this IEnumerable<M> src)
            where M : struct, IMemberOp
                => OpIndex.From(src.Select(h => (h.Id, h)));

        public static OpIndex<M> ToOpIndex<M>(this ReadOnlySpan<M> src)
            where M : struct, IMemberOp
                => OpIndex.From(src.ArrayMap(h => (h.Id, h)));

        public static OpIndex<M> ToOpIndex<M>(this Span<M> src)
            where M : struct, IMemberOp
               => src.ReadOnly().ToOpIndex();
    }        
}