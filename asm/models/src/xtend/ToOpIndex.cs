//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

	partial class XTend
    {
        public static OpIndex<AsmOpBits> ToOpIndex(this IEnumerable<AsmOpBits> src)
            => OpIndex.From(src.Select(x => (x.Op.OpId, x)));

    }
}