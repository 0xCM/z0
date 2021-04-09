//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmStatement
    {
        readonly AsmStatementBuilder Builder;

        public static AsmStatement create()
            => new AsmStatement(new AsmStatementBuilder());

        [MethodImpl(Inline)]
        AsmStatement(AsmStatementBuilder builder)
        {
            Builder = builder;
        }
    }
}