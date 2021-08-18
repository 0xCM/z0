//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.llvm;

    using static Root;
    using static core;

    partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(ushort sdmkey, MC.AsmId asmid, uint encoding, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, asmid, encoding, expr);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(ushort sdmkey, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, 0, 0, expr);
    }
}