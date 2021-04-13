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
    using static TextRules;
    using static HexFormatSpecs;

    [ApiHost]
    public readonly struct AsmBytes
    {
        [Op]
        public static uint Serialize(AsmHexVector src, Span<byte> dst)
        {
            var j=0u;
            first16u(dst) = src.HexSize;
            j+=2;
            var input = bytes(src.Bytes);
            input.CopyTo(slice(dst,j+=src.HexSize));
            input = bytes(src.Offsets);
            input.CopyTo(slice(dst,j));
            j+= (uint)src.Offsets.Length*2;
            return j;
        }

        [Op]
        public static bool parse(string src, out AsmHexCode dst)
        {
            var storage = Cells.alloc(w128);
            var size = parse(span(src),storage.Bytes);
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

        /// <summary>
        /// Parses a nibble
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline), Op]
        public static bool parse(char c, out byte dst)
        {
            if(HexDigitTest.scalar(c))
            {
                dst = (byte)((byte)c - MinScalarCode);
                return true;
            }
            else if(HexDigitTest.upper(c))
            {
                dst = (byte)((byte)c - MinCharCodeU + 0xA);
                return true;
            }
            else if(HexDigitTest.lower(c))
            {
                dst = (byte)((byte)c - MinCharCodeL + 0xa);
                return true;
            }
            dst = byte.MaxValue;
            return false;
        }

        [MethodImpl(Inline), Op]
        public static bool parse(char c0, char c1, out byte dst)
        {
            if(parse(c0, out var d0) && parse(c1, out var d1))
            {
                dst = (byte)((d0 << 4) | d1);
                return true;
            }
            dst = 0;
            return false;
        }

        const char Zero = (char)0;

        [MethodImpl(Inline), Op]
        public static bool nonzero(char c0, char c1)
            => c0 != Zero && c1 != Zero;

        [Op]
        public static int parse(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var input = src;
            var maxbytes = dst.Length;
            var j=0;
            var count = src.Length;
            var c0 = Zero;
            var c1 = Zero;
            for(var i=0; i<count; i++)
            {
                if(j == maxbytes)
                    return j;

                ref readonly var c = ref skip(src,i);
                if(Query.whitespace(c) && nonzero(c0, c1))
                {
                    if(parse(c0, c1, out seek(dst,j)))
                        j++;

                    c0 = Zero;
                    c1 = Zero;
                }
                else
                {
                    if(c0 == Zero)
                        c0 = c;
                    else if(c1 == Zero)
                        c1 = c;
                    else
                    {
                        if(parse(c0, c1, out seek(dst,j)))
                            j++;
                        c0 = Zero;
                        c1 = Zero;
                    }
                }
            }

            if(nonzero(c0, c1) && parse(c0, c1, out seek(dst,j)))
                j++;

            return j;
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

        [Op]
        public static string format(in AsmHexCode src)
            => src.Data.FormatHexData(size(src));

        [MethodImpl(Inline), Op]
        public static AsmHexCode hexcode(ReadOnlySpan<byte> src)
        {
            var cell = Cells.alloc(w128);
            var count = (byte)root.min(src.Length, 15);
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