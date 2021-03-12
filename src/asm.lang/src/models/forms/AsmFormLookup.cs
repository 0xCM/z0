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

    public sealed class AsmFormLookup : Dictionary<string,AsmForm>
    {
        public static AsmFormLookup create()
            => new AsmFormLookup();

        [MethodImpl(Inline)]
        public void AddIfMissing(AsmForm src)
            => TryAdd(src.Expression, src);
    }
}