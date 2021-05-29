//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;
    using static gcpu;
    using static ByteBlocks;

    [ApiHost]
    public readonly struct AsmHexCodes
    {
        public static RexPrefix RexW => RexPrefixCode.Rex48;

        public static RexPrefix Rex40 => RexPrefixCode.Rex40;

        public static RegDigit rd0 => RegDigitCode.rd0;

        public static RegDigit rd1 => RegDigitCode.rd1;

        public static RegDigit rd2 => RegDigitCode.rd2;

        public static RegDigit rd3 => RegDigitCode.rd3;

        public static RegDigit rd4 => RegDigitCode.rd4;

        public static RegDigit rd5 => RegDigitCode.rd5;

        public static RegDigit rd6 => RegDigitCode.rd6;

        public static RegDigit rd7 => RegDigitCode.rd7;

        [MethodImpl(Inline)]
        static SpanWriter write(Span<byte> dst)
            => Spans.writer(dst);

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0, Hex8 a1)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0, Hex8 a1, RegDigit rd)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(RexPrefix a0, Hex8 a1, Imm64 a2)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Imm8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex16 a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write16(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex8 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write8(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex8 a2, Hex8 a3)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write8(a2);
            writer.Write8(a3);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex16 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write16(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex32 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write32(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, Hex32 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write32(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode asmhex(Hex8 a0, Hex8 a1, ulong a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        static Span<byte> buffer()
            => alloc(n16).Bytes;

        [MethodImpl(Inline), Op]
        static AsmHexCode close(in SpanWriter writer, Span<byte> dst)
        {
            seek(dst, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(first(recover<Cell128>(dst)));
        }

        [MethodImpl(Inline), Op]
        static AsmHexCode load(SpanWriter writer)
        {
            seek(writer.Target, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(vload<byte>(w128, writer.Target));
        }
    }
}