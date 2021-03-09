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

    partial struct AsmExpr
    {
        public sealed class FormLookup : Dictionary<string,Form>
        {
            public static FormLookup create()
                => new FormLookup();

            [MethodImpl(Inline)]
            public void AddIfMissing(Form src)
                => TryAdd(src.Expression, src);
        }
    }
}