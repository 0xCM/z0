//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using llvm;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(ushort sdmkey, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, 0, AsmOpCodeBits.Empty, expr);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(ushort sdmkey, AsmId id, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, id, AsmOpCodeBits.Empty, expr);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(ushort sdmkey, AsmId asmid, AsmOpCodeBits bits, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, asmid, bits, expr);
    }
}