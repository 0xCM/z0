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

    public enum AsmOpCodeId : ushort
    {
        /// <summary>
        /// 24 ib | AND AL, imm8
        /// </summary>
        and_al_imm8,

        /// <summary>
        /// 25 iw | AND AX, imm16
        /// </summary>
        and_ax_imm16,

        /// <summary>
        /// 25 id | AND EAX, imm32
        /// </summary>
        and_eax_imm32,

        /// <summary>
        /// REX.W + 25 id | AND RAX, imm32
        /// </summary>
        and_rax_imm32,

        /// <summary>
        /// 80 /4 ib | AND r8, imm8
        /// </summary>
        and_r8_imm8,

        /// <summary>
        /// 80 /4 ib | AND m8, imm8
        /// </summary>
        and_m8_imm8,

        /// <summary>
        /// REX + 80 /4 ib | AND r8, imm8
        /// </summary>
        and_r8_imm8_rex,

        /// <summary>
        /// REX + 80 /4 ib | AND m8, imm8
        /// </summary>
        and_m8_imm8_rex,

        /// <summary>
        /// 81 /4 iw | AND r16, imm16
        /// </summary>
        and_r16_imm16,

        /// <summary>
        /// 81 /4 iw | AND m16, imm16
        /// </summary>
        and_m16_imm16,

        /// <summary>
        /// 81 /4 id | AND r32, imm32
        /// </summary>
        and_r32_imm32,

        /// <summary>
        /// 81 /4 id | AND m32, imm32
        /// </summary>
        and_m32_imm32,

        /// <summary>
        /// REX.W + 81 /4 id | AND r64, imm32
        /// </summary>
        and_r64_imm32,

        /// <summary>
        /// REX.W + 81 /4 id | AND m64, imm32
        /// </summary>
        and_m64_imm32,

        /// <summary>
        /// 83 /4 ib | AND r16, imm8
        /// </summary>
        and_r16_imm8,

        /// <summary>
        /// 83 /4 ib | AND m16, imm8
        /// </summary>
        and_m16_imm8,

        /// <summary>
        /// 83 /4 ib | AND r32, imm8
        /// </summary>
        amd_r32_imm8,

        /// <summary>
        /// 83 /4 ib | AND m32, imm8
        /// </summary>
        and_m32_imm8,

        /// <summary>
        /// REX.W + 83 /4 ib | AND r64, imm8
        /// </summary>
        and_r64_imm8,

        /// <summary>
        /// REX.W + 83 /4 ib | AND m64, imm8
        /// </summary>
        and_m64_imm8,

        /// <summary>
        /// 20 /r | AND r8, r8
        /// </summary>
        and_r8_r8,

        /// <summary>
        /// 20 /r | AND m8, r8
        /// </summary>
        and_m8_r8,

        /// <summary>
        /// REX + 20 /r AND r8, r8
        /// </summary>
        and_r8_r8_rex,

        /// <summary>
        /// REX + 20 /r | AND m8, r8
        /// </summary>
        and_m8_r8_rex,

        /// <summary>
        /// 21 /r | AND r16, r16
        /// </summary>
        and_r16_r16,

        /// <summary>
        /// 21 /r | AND m16, r16
        /// </summary>
        and_m16_r16,

        /// <summary>
        /// 21 /r | AND r32, r32
        /// </summary>
        and_r32_r32,

        /// <summary>
        /// 21 /r | AND m32, r32
        /// </summary>
        and_m32_r32,

        /// <summary>
        /// REX.W + 21 /r | AND r64, r64
        /// </summary>
        and_r64_r64,

        /// <summary>
        /// REX.W + 21 /r | AND m64, r64
        /// </summary>
        and_m64_r64,

        /// <summary>
        /// 22 /r | AND r8, r8
        /// </summary>
        and_r8_r8_x22,

        /// <summary>
        /// 22 /r | AND r8, m8
        /// </summary>
        and_r8_m8,

        /// <summary>
        /// 23 /r | AND r16, m16
        /// </summary>
        and_r16_m16,

        /// <summary>
        /// 23 /r | AND r32, m32
        /// </summary>
        and_r32_m32,

        /// <summary>
        /// REX.W + 23 /r | AND r64, m64
        /// </summary>
        and_r64_m64,
    }


    [ApiHost]
    public readonly struct AsmOpCodes
    {

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(EscapePrefix escape, byte a)
            => new AsmOpCode((uint32(a) << 8) | ((uint)escape));

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(EscapePrefix escape, byte a, byte b)
            => new AsmOpCode((uint32(a) << 16) | (uint32(b) << 8) | escape);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(MandatoryPrefix mandatory, EscapePrefix escape, byte a)
            => new AsmOpCode((uint32(a) << 16) | ((uint)escape) << 8 | (uint)mandatory);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(MandatoryPrefix mandatory, EscapePrefix escape, byte a, byte b)
            => new AsmOpCode((uint32(a) << 24) | (uint32(b) << 16) | ((uint)escape) << 8 | (uint)mandatory);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0)
            => spec(b0, 0, 0, OpCodeTokenKind.None);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte a, byte b)
            => spec(a, b, 0, OpCodeTokenKind.None);

        /// <summary>
        /// Example: XOR r/m32, imm8 | 83 /6 ib
        /// Example: AND r/m8,imm8 | 80 /4 ib
        /// </summary>
        /// <param name="b0">The first opcode byte</param>
        /// <param name="ext">The register field digit</param>
        /// <param name="iz">The imm size</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0, RegDigit ext, ImmSize iz)
            => spec(b0, (byte)ext, (byte)iz, OpCodeTokenKind.RexBExtension | OpCodeTokenKind.ImmSize);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0, ImmSize iz)
            => spec(b0,(byte)iz, 0, OpCodeTokenKind.ImmSize);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0, byte b1, byte b2, OpCodeTokenKind b3)
            => new AsmOpCodeSpec(
                bw32(b0) |
                (bw32(b1) << 8) |
                (bw32(b2) << 16) |
                (bw32(b3) << 24)
                );
    }
}