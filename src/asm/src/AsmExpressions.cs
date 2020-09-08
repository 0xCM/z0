//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmExpressions
    {
        [MethodImpl(Inline), Op]
        public static MnemonicExpression mnemonic(in AsmOpCodeTable src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline), Op]
        public static CpuidExpression cpuid(in AsmOpCodeTable src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(in AsmOpCodeTable src)
            => new AsmOpCode(src.OpCode);

        [MethodImpl(Inline), Op]
        public static AsmFxPattern fx(in AsmOpCodeTable src)
            => new AsmFxPattern(src.Instruction);
    }
}