//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;
    using static memory;

    partial class Nasm
    {
        /// <summary>
        /// Creates a nasm asm source document
        /// </summary>
        /// <param name="expr">The sequence of expressions that comprise the document</param>
        /// <param name="x64">The bitness</param>
        [MethodImpl(Inline), Op]
        public NasmSource Source(Index<AsmExpr> expr, bool x64 = true)
            => source(expr,x64);
    }
}