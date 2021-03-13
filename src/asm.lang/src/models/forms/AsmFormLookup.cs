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

    public sealed class AsmFormLookup : Dictionary<string,AsmFormExpr>
    {
        public static AsmFormLookup create()
            => new AsmFormLookup();

        [MethodImpl(Inline)]
        public void AddIfMissing(AsmFormExpr src)
            => TryAdd(src.Expression, src);
    }
}