//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmDisassembly disassembly(Hex64 offset, AsmExpr statement)
            => new AsmDisassembly(offset, statement);

        [MethodImpl(Inline), Op]
        public static AsmDisassembly disassembly(Hex64 offset, AsmExpr statement, AsmHexCode code)
            => new AsmDisassembly(offset, statement, code);
    }
}