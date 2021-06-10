//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpCodeTokens;

    [ApiHost]
    public readonly struct AsmOpCodes
    {
        public static AsmOpCodeExpr conform(string src)
            => asm.opcode(src.Replace("o32 ", EmptyString).Replace("o16 ", EmptyString).Replace("+", " +"));

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0, AsmOpCodeTokens.ImmSize imm)
            => new AsmOpCode(math.or(normalize(b0), math.sll(normalize(TokenKind.ImmSize),4)) << 24 | normalize(b0));

        /// <summary>
        /// Example: AND r/m8,imm8 | 80 /4 ib
        /// </summary>
        /// <param name="b0"></param>
        /// <param name="r"></param>
        /// <param name="imm"></param>
        /// <returns></returns>
        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0, RegDigit r, AsmOpCodeTokens.ImmSize imm)
            => new AsmOpCode(math.or(normalize(b0), math.sll(normalize(TokenKind.ImmSize | TokenKind.OpCodeExt),4)) << 24 | normalize(b0));

        [MethodImpl(Inline)]
        static uint normalize<T>(T src)
            where T : unmanaged
                => core.bw32(src);
    }
}