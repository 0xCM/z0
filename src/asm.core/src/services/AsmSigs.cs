//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmSigTokens;

    [ApiHost]
    public partial class AsmSigs : Service<AsmSigs>
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AsmSigToken<K> token<K>(SigTokenKind kind, K value)
            where K : unmanaged
                => new AsmSigToken<K>(kind,value);
    }
}