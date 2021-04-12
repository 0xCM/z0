//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    using Z0.Asm;

    partial class Nasm
    {
        /// <summary>
        /// Creates a nasm asm source document
        /// </summary>
        /// <param name="expr">The sequence of expressions that comprise the document</param>
        /// <param name="x64">The bitness</param>
        [Op]
        public NasmSource Source(ReadOnlySpan<AsmExpr> expr, bool x64 = true)
            => source(expr.ToArray(), x64);
    }
}