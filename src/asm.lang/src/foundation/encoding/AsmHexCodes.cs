//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static gcpu;
    using static MemBlocks;

    [ApiHost]
    public readonly struct AsmHexCodes
    {
        public const RexPrefixCode RexW = RexPrefixCode.RexW;

        public const RegDigitCode rd0 = RegDigitCode.rd0;

        public const RegDigitCode rd1 = RegDigitCode.rd1;

        public const RegDigitCode rd2 = RegDigitCode.rd2;

        public const RegDigitCode rd3 = RegDigitCode.rd3;

        public const RegDigitCode rd4 = RegDigitCode.rd4;

        public const RegDigitCode rd5 = RegDigitCode.rd5;

        public const RegDigitCode rd6 = RegDigitCode.rd6;

        public const RegDigitCode rd7 = RegDigitCode.rd7;

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0, Hex8 a1)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0, Hex8 a1, RegDigit rd)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0, Hex8 a1, Imm64 a2)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Imm8 a1)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex16 a0)
        {
            var writer = memory.writer(buffer());
            writer.Write16(a0);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex8 a2)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write8(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex8 a2, Hex8 a3)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write8(a2);
            writer.Write8(a3);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex16 a2)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write16(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex32 a1)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write32(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex32 a2)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write32(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, ulong a2)
        {
            var writer = memory.writer(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        static Span<byte> buffer()
            => block(n16).Bytes;

        [MethodImpl(Inline), Op]
        static AsmHexCode load(SpanWriter writer)
        {
            seek(writer.Target,AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(vload<byte>(w128, writer.Target));
        }
    }
}