//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static Root;
    using static core;
    using static Typed;

    using K = RexPrefixCode;

    [ApiHost]
    public readonly struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static Hex8 rex()
            => (byte)K.Base;

        [MethodImpl(Inline), Op]
        public static AsmHexCode rex(uint4 wrxb, uint4 index)
        {
            var dst = AsmHexCode.Empty;
            dst.Cell(index) = rex(wrxb);
            dst.Cell(15) = 1;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Hex8 rex(uint4 wrxb)
            => math.or((byte)K.Base, (byte)wrxb);

        [MethodImpl(Inline), Op]
        public static ref ModRm modrm(in AsmHexCode src, uint4 offset)
            => ref @as<byte,ModRm>(skip(src.Bytes, offset));

        [MethodImpl(Inline), Op]
        public static bit test(K src, K match)
            => (src & match) == match;

        [MethodImpl(Inline), Op]
        public static Hex8 rex(K kind)
        {
            var dst = rex();

            if(test(kind, K.W))
                dst |= (byte)K.W;

            if(test(kind, K.R))
                dst |= (byte)K.R;

            if(test(kind, K.X))
                dst |= (byte)K.X;

            if(test(kind, K.W))
                dst |= (byte)K.W;

            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(RexPrefix a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(RexPrefix a0, Hex8 a1)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Hex8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex16 a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write16(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Hex8 a1, Hex8 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write8(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Hex8 a1, Hex8 a2, Hex8 a3)
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
        public static AsmHexCode encode(Hex8 a0, Hex8 a1, Hex16 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write16(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Hex32 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write32(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(RexPrefix a0, Hex8 a1, Imm64 a2)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Imm8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        static Span<byte> buffer()
            => ByteBlocks.alloc(n16).Bytes;

        [MethodImpl(Inline)]
        static SpanWriter write(Span<byte> dst)
            => Spans.writer(dst);

        [MethodImpl(Inline), Op]
        static AsmHexCode close(in SpanWriter writer, Span<byte> dst)
        {
            seek(dst, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(first(recover<Cell128>(dst)));
        }

        [MethodImpl(Inline)]
        static unsafe Vector128<byte> vload(Span<byte> src)
            => LoadDquVector128(gptr(first(src)));

        [MethodImpl(Inline), Op]
        static AsmHexCode load(SpanWriter writer)
        {
            seek(writer.Target, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(vload(writer.Target));
        }
    }
}