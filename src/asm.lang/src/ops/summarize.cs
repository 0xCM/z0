//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmStatementSummary summary(MemoryAddress @base, Address16 offset, AsmStatementExpr expr, AsmThumbprintExpr thumbprint)
            => new AsmStatementSummary(@base, offset, expr, thumbprint);
    }
}