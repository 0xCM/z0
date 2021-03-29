//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public sealed class AsmOpCodeLookup : Dictionary<string,AsmOpCodeExpr>
    {
        public static AsmOpCodeLookup create()
            => new AsmOpCodeLookup();

        [MethodImpl(Inline)]
        public void AddIfMissing(AsmOpCodeExpr src)
            => TryAdd(src.Format(), src);
    }
}