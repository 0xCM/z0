//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;

    partial class Nasm
    {
        [MethodImpl(Inline), Op]
        public static NasmSource source(Index<AsmExpr> expr, bool x64 = true)
            => new NasmSource(expr,x64);
    }
}