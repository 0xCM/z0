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
        public static AsmOpCode opcode(uint key, in CharBlock48 expr)
            => new AsmOpCode(key, AsmOpCodeBits.Empty, expr);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(AsmId id, in CharBlock48 expr)
            => new AsmOpCode(id, AsmOpCodeBits.Empty, expr);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(AsmId asmid, AsmOpCodeBits bits, in CharBlock48 expr)
            => new AsmOpCode(asmid, bits, expr);
    }
}