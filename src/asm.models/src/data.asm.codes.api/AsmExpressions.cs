//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
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
        public static MnemonicExpression mnemonic(in AsmOpCodeRow src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline), Op]
        public static CpuidExpression cpuid(in AsmOpCodeRow src)
            => new CpuidExpression(src.CpuId);

        /// <summary>
        /// Selects the opcode expression from the source table
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression opcode(in AsmOpCodeRow src)
            => new AsmOpCodeExpression(src.OpCode);

        /// <summary>
        /// Selects the instruction pattern from the source table
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static AsmInstructionPattern fx(in AsmOpCodeRow src)
            => new AsmInstructionPattern(src.Instruction);
    }
}