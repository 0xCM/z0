//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpCodeTokens;
    using static core;

    [ApiHost]
    public readonly struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0)
            => opcode(b0, 0, 0, TokenKind.None);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0, byte b1)
            => opcode(b0, b1, 0, TokenKind.None);

        /// <summary>
        /// Example: XOR r/m32, imm8 | 83 /6 ib
        /// Example: AND r/m8,imm8 | 80 /4 ib
        /// </summary>
        /// <param name="b0">The first opcode byte</param>
        /// <param name="ext">The register field digit</param>
        /// <param name="iz">The imm size</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0, RegExtension ext, ImmSize iz)
            => opcode(b0, (byte)ext, (byte)iz, TokenKind.RegExtension | TokenKind.ImmSize);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0, ImmSize iz)
            => opcode(b0,(byte)iz, 0, TokenKind.ImmSize);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(byte b0, byte b1, byte b2, TokenKind b3)
            => new AsmOpCode(
                bw32(b0) |
                (bw32(b1) << 8) |
                (bw32(b2) << 16) |
                (bw32(b3) << 24)
                );
    }
}