//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct BitFormatter
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Formats a span as a bitgrid
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        public static string grid(Span<byte> src, int rowlen, int? maxbits = null, bool showrow = false)
        {
            var dst = chars(src);
            var sb = text.build();
            var limit = maxbits ?? dst.Length;
            for(int i=0, rowidx=0; i<limit; i+= rowlen, rowidx++)
            {
                var remaining = dst.Length - i;
                var segment = Math.Min(remaining, rowlen);
                var rowbits = dst.Slice(i, segment);
                var rowprefix = showrow ? $"{rowidx.ToString().PadRight(3)} | " : string.Empty;
                var rowformat = rowprefix + new string(rowbits.Intersperse(Chars.Space));
                sb.AppendLine(rowformat);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats the content of a generic span of primal cells as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        public static string grid<T>(Span<T> src, int rowlen, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => grid(src.Bytes(),rowlen, maxbits, showrow);

        [MethodImpl(Inline), Closures(Closure)]
        public static BitFormatter<T> create<T>(BitFormat? config = null)
            where T : struct
                => new BitFormatter<T>(config ?? BitFormatter.configure());

        [Op, Closures(Closure)]
        public static string format<T>(T src, int? digits = null)
            where T : unmanaged
                => format(src, digits != null ? limited((uint)digits.Value, digits.Value)  : configure());

        public static BitFormat DefaultConfig
            => configure(false);

        [Op]
        public static void render(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var input = span(src);
            var config = DefaultConfig;
            bits(src, dst.Length, dst);
        }

        [Op, Closures(Closure)]
        public static string format<T>(ReadOnlySpan<T> src, BitFormat? config = null)
            where T : unmanaged
        {
            var dst = text.buffer();
            var cells = src.Length;
            var cfg = config ?? configure();
            for(var i=0; i<cells; i++)
                dst.Append(_format<T>(skip(src,i), cfg));
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string format<T>(Span<T> src, BitFormat? config = null)
            where T : unmanaged
                => format(src.ReadOnly(), config);

        [MethodImpl(Inline), Op]
        public static BitFormat configure(bool tlz = false)
            => BitFormatOptions.bits(tlz);

        [MethodImpl(Inline), Op]
        public static BitFormat limited(uint maxbits, int? zpad = null)
            => BitFormatOptions.bitmax(maxbits, zpad);

        [MethodImpl(Inline), Op]
        public static BitFormat limited(uint maxbits, uint zpad)
            => BitFormatOptions.bitmax(maxbits, (int)zpad);

        [MethodImpl(Inline), Op]
        public static BitFormat blocked(int width, char? sep = null, uint? maxbits = null, bool specifier = false)
            => BitFormatOptions.bitblock(width, sep, maxbits, specifier);

        [Op]
        public static int render(in byte src, int length, uint maxbits, Span<char> dst)
            => _format(src, length, maxbits,dst);

        [Op]
        public static int format(in byte src, int length, uint maxbits, Span<char> dst)
            => _format(src, length, maxbits, dst);

        [Op]
        public void Format(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
            => render(first(src), src.Length, maxbits, dst);

        [Op]
        public static int format(byte src, uint maxbits, Span<char> dst, ref int k)
            => render8(src, maxbits, dst, ref k);

        [Op]
        public static string format(params bit[] src)
            => format(src.ToReadOnlySpan());

        public static string format(ReadOnlySpan<bit> src)
        {
            var count = src.Length;
            if(count == 0)
                return EmptyString;

            var terms = src;
            Span<char> dst = stackalloc char[count];
            render(src, dst);
            return new string(dst);
        }

        [Op]
        public static void render(ReadOnlySpan<bit> src, Span<char> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(src,i).ToChar();
        }

        [Op]
        public static uint format(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
        {
            int k = 0;
            return (uint)format(first(src), maxbits, dst, ref k);
        }

        [Op, Closures(Closure)]
        public static string format<T>(T src, in BitFormat config)
            where T : struct
                => format(bytes(src).ReadOnly(), config);

        [Op, Closures(Closure)]
        public static string format<T>(T src)
            where T : struct
                => format(src, configure());

        [Op]
        public static string format(ReadOnlySpan<byte> src, in BitFormat config)
            => _format(src,config);

        [Op]
        public static int bits(ReadOnlySpan<byte> src, Count maxbits, Span<char> dst)
            => _format(first(src), src.Length, maxbits, dst);

        public static Span<char> chars(ReadOnlySpan<byte> src)
        {
            var dst = span<char>(src.Length*8);
            var input = span(src);
            var config = DefaultConfig;
            render(src, dst);
            return dst;
        }

        [Op]
        public static string format(object src, TypeCode type)
        {
            if(type == TypeCode.Byte || type == TypeCode.SByte)
                return format8(src);
            else if(type == TypeCode.UInt16 || type == TypeCode.Int16)
                return format16(src);
            else if(type == TypeCode.UInt32  || type == TypeCode.Int32 || type == TypeCode.Single)
                return format32(src);
            else if(type == TypeCode.UInt64 || type == TypeCode.Int64 || type == TypeCode.Double)
                return format64(src);
            else
                return EmptyString;
        }

        static string _format<T>(T src, in BitFormat config)
            where T : struct
                => _format(bytes(src), config);

        [Op]
        static string _format(ReadOnlySpan<byte> src, in BitFormat config)
        {
            var count = src.Length*8;
            var dst = span<char>(count);
            dst.Fill(Chars.D0);

            bits(src, config.MaxBitCount, dst);

            dst.Reverse();

            var bs = new string(dst);

            if(config.TrimLeadingZeros)
                bs = bs.TrimStart(Chars.D0);

            if(config.ZPad != 0)
                bs = bs.PadLeft(config.ZPad, Chars.D0);

            if(config.BlockWidth != 0)
                bs = string.Join(config.BlockSep, bs.Partition(config.BlockWidth));

            return config.SpecifierPrefix ? "0b" + bs : bs;
        }

        [Op]
        static int _format(in byte src, int length, uint maxbits, Span<char> dst)
        {
            var k=0;
            for(var i=0u; i<length; i++)
            {
                render8(skip(src,i), maxbits, dst, ref k);
                if(k >= maxbits)
                    break;
            }
            return k;
        }

        [Op]
        static int render8(byte src, uint maxbits, Span<char> dst, ref int k)
        {
            for(byte j=0; j<8; j++, k++)
            {
                if(k>=maxbits)
                    break;
                seek(dst, (uint)k) = @char(@bool(bit.test(src, j)));
            }
            return k;
        }

        [Op]
        static string format8(object src)
            => create<byte>().Format((byte)NumericBox.rebox(src, NumericKind.U8));

        [Op]
        static string format16(object src)
            => create<ushort>().Format((ushort)NumericBox.rebox(src, NumericKind.U16));

        [Op]
        static string format32(object src)
            => create<uint>().Format((uint)NumericBox.rebox(src, NumericKind.U32));

        [Op]
        static string format64(object src)
            => create<ulong>().Format((ulong)NumericBox.rebox(src, NumericKind.U64));
    }
}