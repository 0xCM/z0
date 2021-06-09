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

    [ApiHost]
    public readonly struct AsmBytes
    {
        [MethodImpl(Inline), Op]
        public static ref ModRm modrm(in AsmHexCode src, uint4 offset)
            => ref @as<byte,ModRm>(skip(src.Bytes, offset));

        [Op]
        public static bool parse(ReadOnlySpan<char> src, out AsmHexCode dst)
        {
            var storage = Cells.alloc(w128);
            var size = Hex.parse(src, storage.Bytes);
            if(size == 0 || size > 15)
            {
                dst = AsmHexCode.Empty;
                return false;
            }
            else
            {
                dst = new AsmHexCode(storage);
                dst.Cell(15) = (byte)size;
                return true;
            }
        }

        [Op]
        public static AsmHexCode parse(string src)
        {
            var dst = AsmHexCode.Empty;
            parse(src.Trim(), out dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(ulong src)
        {
            var size = Bits.effsize(src);
            var data = slice(core.bytes(src),0,size);
            var storage = 0ul;
            var buffer = core.bytes(storage);
            core.reverse(data, buffer);
            return new AsmHexCode(Cells.cell128(u64(first(buffer)), (ulong)size << 56));
        }

        [MethodImpl(Inline), Op]
        public static byte size(in AsmHexCode src)
            => BitNumbers.cell8(src.Data, AsmHexCode.SizeIndex);

        [MethodImpl(Inline), Op]
        public static int compare(in AsmHexCode a, in AsmHexCode b)
        {
            var left = recover<ulong>(raw(a));
            var right = recover<ulong>(raw(b));
            var x = first(left).CompareTo(first(right));
            if(x != 0)
                return x;
            else
                return skip(left,1).CompareTo(skip(right,1));
        }

        [MethodImpl(Inline), Op]
        public static bool eq(in AsmHexCode a, in AsmHexCode b)
            => a.Data.Equals(b.Data);

        [MethodImpl(Inline), Op]
        public static int hash(in AsmHexCode src)
            => (int)alg.hash.calc(data(src));

        [MethodImpl(Inline), Op]
        public static Span<byte> data(in AsmHexCode src)
            => slice(bytes(src.Data), 0, src.Size);

        [MethodImpl(Inline), Op]
        static Span<byte> raw(in AsmHexCode src)
            => bytes(src.Data);

        [MethodImpl(Inline), Op]
        public static T convert<T>(in AsmHexCode src)
            where T : unmanaged
                => first(recover<T>(data(src)));

        [MethodImpl(Inline), Op]
        public static AsmHexCode code()
            => default;

        [MethodImpl(Inline), Op]
        public static AsmHexCode hexcode(ReadOnlySpan<byte> src)
        {
            var cell = Cells.alloc(w128);
            var count = (byte)min(src.Length, 15);
            var dst = bytes(cell);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            BitNumbers.cell8(cell, 15) = count;
            return new AsmHexCode(cell);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex8 a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(RexPrefix a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(RexPrefix a0, Hex8 a1)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(RexPrefix a0, Hex8 a1, RegDigit rd)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(RexPrefix a0, Hex8 a1, Imm64 a2)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex8 a0, Hex8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex8 a0, Imm8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex16 a0)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write16(a0);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex8 a0, Hex8 a1, Hex8 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write8(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex8 a0, Hex8 a1, Hex8 a2, Hex8 a3)
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
        public static AsmHexCode code(Hex8 a0, Hex8 a1, Hex16 a2)
        {
            var dst = buffer();
            var writer = write(dst);
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write16(a2);
            return close(writer, dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(Hex8 a0, Hex32 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write32(a1);
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