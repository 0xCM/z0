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
        public sealed class OpCodeLookup : Dictionary<string,OpCode>
        {
            public static OpCodeLookup create()
                => new OpCodeLookup();

            [MethodImpl(Inline)]
            public void AddIfMissing(OpCode src)
                => TryAdd(src.Format(), src);
        }
    }
}