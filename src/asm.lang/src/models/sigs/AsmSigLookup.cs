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

    public sealed class AsmSigLookup : Dictionary<string,AsmSig>
    {
        public static AsmSigLookup create()
            => new AsmSigLookup();

        [MethodImpl(Inline)]
        public void AddIfMissing(AsmSig src)
            => TryAdd(src.Format(), src);
    }
}