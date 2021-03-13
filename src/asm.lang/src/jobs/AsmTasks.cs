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
    public readonly struct AsmTasks
    {
        [MethodImpl(Inline), Op]
        public static AsmEncodingTask encoding(Identifier id, AsmStatementExpr expr)
            => new AsmEncodingTask(id,expr);
    }
}