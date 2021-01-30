//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmExpr
    {

        [MethodImpl(Inline), Op]
        public static AsmMnemonicExpr mnemonic(asci32 src)
            => new AsmMnemonicExpr(src);

        /// <summary>
        /// Defines a <see cref='SigOperandExpr'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static SigOperandExpr sigop(asci16 src)
            => new SigOperandExpr(src);

        /// <summary>
        /// Defines a <see cref='AsmOpCodeExpr'/>
        /// </summary>
        /// <param name="src">The source text</param>
        /// <remarks>
        /// Examples:
        /// 14 ib
        /// REX.W+ 81 /2 id
        /// VEX.NDS.LIG.F2.0F.WIG 58 /r
        /// REX+ 20 /r
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpr opcode(asci32 src)
            => new AsmOpCodeExpr(src);

        /// <summary>
        /// Defines a signature expression
        /// </summary>
        /// <param name="src">The source text</param>
        /// <remarks>
        /// Instruction signatures are of the form
        /// 0 operands: {Mnemonic}
        /// 1 operand: {Mnemonic}{ }{op1}
        /// 2 operands: {Mnemonic}{ }{op1}{,}{op2}
        /// 3 operands: {Mnemonic}{ }{op1}{,}{op2},{op3}
        /// Example: PCMPISTRI xmm1, xmm2/m128, imm8
        /// <remarks>
        [MethodImpl(Inline), Op]
        public static AsmSigExpr sig(asci64 src)
            => new AsmSigExpr(src);
    }
}