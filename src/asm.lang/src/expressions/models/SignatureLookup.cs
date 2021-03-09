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
        public sealed class SignatureLookup : Dictionary<string,Signature>
        {
            public static SignatureLookup create()
                => new SignatureLookup();

            [MethodImpl(Inline)]
            public void AddIfMissing(Signature src)
                => TryAdd(src.Format(), src);
        }
    }
}