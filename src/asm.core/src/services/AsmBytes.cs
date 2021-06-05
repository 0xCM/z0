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

    [ApiHost]
    public readonly struct AsmBytes
    {
        [MethodImpl(Inline), Op]
        public static ref ModRm modrm(in AsmHexCode src, uint4 offset)
            => ref @as<byte,ModRm>(skip(src.Bytes, offset));

        public static bool parse(string src, out AsmHexCode dst)
        {
            var storage = Cells.alloc(w128);
            var size = Hex.parse(span(src.Trim()), storage.Bytes);
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

        [MethodImpl(Inline), Op]
        public static byte size(in AsmHexCode src)
            => BitNumbers.cell8(src.Data, AsmHexCode.SizeIndex);

        [MethodImpl(Inline), Op]
        public static int compare(in AsmHexCode a, in AsmHexCode b)
        {
            var left = recover<ulong>(rawbytes(a));
            var right = recover<ulong>(rawbytes(b));
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
            => (int)alg.hash.calc(hexbytes(src));

        [MethodImpl(Inline), Op]
        public static Span<byte> hexbytes(in AsmHexCode src)
            => slice(bytes(src.Data), 0, src.Size);

        [MethodImpl(Inline), Op]
        public static Span<byte> rawbytes(in AsmHexCode src)
            => bytes(src.Data);

        [MethodImpl(Inline), Op]
        public static T convert<T>(in AsmHexCode src)
            where T : unmanaged
                => first(recover<T>(hexbytes(src)));

        [MethodImpl(Inline), Op]
        public static AsmHexCode hexcode()
            => default;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static AsmHexCode hexcode<T>(T src)
            where T : unmanaged
                => hexcode(bytes(src));

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

        [Op]
        public static AsmHexCode hexcode(string src)
        {
            var dst = AsmHexCode.Empty;
            hexcode(src, out dst);
            return dst;
        }

        [Op]
        public static bool hexcode(string src, out AsmHexCode dst)
        {
            if(HexByteParser.parse(src, out var data))
            {
                dst = data;
                return true;
            }
            else
            {
                dst = AsmHexCode.Empty;
                return false;
            }
        }
    }
}