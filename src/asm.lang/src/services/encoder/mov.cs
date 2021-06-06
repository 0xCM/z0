//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmInstructions;
    using static AsmOps;
    using static AsmHexCodes;

    partial class AsmEncoder
    {
        // REX.W + B8+ rd io | MOV r64, imm64           | OI    | Valid       | N.E.            | Move imm64 to r64.                                             |
        [MethodImpl(Inline), Op]
        public static Mov mov(r64 r64, Imm64 imm64)
            => AsmBytes.code(RexW, (Hex8)(0xb8 + (byte)r64.Index), imm64);
    }
}