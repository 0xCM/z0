//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmStatements
    {
        readonly TableSpan<AsmStatement> Data;

        [MethodImpl(Inline)]
        public AsmStatements(AsmStatement[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator AsmStatements(AsmStatement[] src)
            => new AsmStatements(src);
    }
}