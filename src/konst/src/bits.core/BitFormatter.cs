//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static z;

    [ApiHost(ApiNames.BitFormatter, true)]
    public readonly struct BitFormatter
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static void format(byte[] src, Span<char> dst)
        {
            var input = span(src);
            var config = BitFormat.Default;
            bits(src, dst.Length, dst);
        }

        public static string format<T>(ReadOnlySpan<T> src, BitFormat? config = null)
            where T : unmanaged
        {
            var dst = Buffers.text();
            var cells = src.Length;
            var wCell = bitwidth<T>();
            var cfg = config ?? BitFormatter.configure();
            for(var i=0; i<cells; i++)
                dst.Append(_format<T>(skip(src,i), cfg));
            return dst.Emit();
        }

        public static string format<T>(Span<T> src, BitFormat? config = null)
            where T : unmanaged
                => format(src.ReadOnly(), config);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => default;

        [MethodImpl(Inline), Op]
        public static BitFormat configure(bool tlz = false)
            => BitFormatOptions.bits(tlz);

        [MethodImpl(Inline), Op]
        public static BitFormat limited(uint maxbits, int? zpad = null)
            => BitFormatOptions.bitmax(maxbits, zpad);

        [MethodImpl(Inline), Op]
        public static BitFormat blocked(int width, char? sep = null, uint? maxbits = null, bool specifier = false)
            => BitFormatOptions.bitblock(width, sep, maxbits, specifier);

        [MethodImpl(Inline), Op]
        public static void Format(in byte src, int length, uint maxbits, Span<char> dst)
            => _format(src, length,maxbits,dst);

        [MethodImpl(Inline), Op]
        public static void format(in byte src, int length, uint maxbits, Span<char> dst)
            => _format(src, length, maxbits, dst);

        [MethodImpl(Inline), Op]
        public void Format(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
            => Format(first(src), src.Length, maxbits, dst);

        [MethodImpl(Inline), Op]
        public static void format(byte src, uint maxbits, Span<char> dst, ref int k)
            => _format(src, maxbits, dst, ref k);

        [Op]
        public static string format(params bit[] src)
        {
            var count = src.Length;
            if(count == 0)
                return EmptyString;

            var terms = @readonly(src);
            Span<char> dst = stackalloc char[count];
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(terms,i).ToChar();
            return new string(dst);
        }

        [MethodImpl(Inline)]
        public static uint format(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
        {
            int k = 0;
            format(first(src), maxbits, dst, ref k);
            return (uint)k;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(T src, in BitFormat config)
            where T : struct
                => format(z.bytes(src).ReadOnly(), config);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(T src)
            where T : struct
                => format(src, BitFormatter.configure());

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<byte> src, in BitFormat config)
            => _format(src,config);


        [MethodImpl(Inline), Op]
        public static void bits(ReadOnlySpan<byte> src, Count maxbits, Span<char> dst)
            => _format(first(src), src.Length, maxbits, dst);

        [Op]
        public static ReadOnlySpan<char> chars(byte[] src)
        {
            var dst = span<char>(src.Length*8);
            var input = span(src);
            var config = BitFormat.Default;
            format(src, dst);
            return dst;
        }


        [MethodImpl(Inline), Op]
        public static string format(object src, TypeCode type)
        {
            if(type == TypeCode.Byte || type == TypeCode.SByte)
                return BitFormatter.create<byte>().Format((byte)rebox(src, NumericKind.U8));
            else if(type == TypeCode.UInt16 || type == TypeCode.Int16)
                return BitFormatter.create<ushort>().Format((ushort)rebox(src, NumericKind.U16));
            else if(type == TypeCode.UInt32  || type == TypeCode.Int32 || type == TypeCode.Single)
                return BitFormatter.create<uint>().Format((uint)rebox(src, NumericKind.U32));
            else if(type == TypeCode.UInt64 || type == TypeCode.Int64 || type == TypeCode.Double)
                return BitFormatter.create<ulong>().Format((ulong)rebox(src, NumericKind.U64));
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

        [MethodImpl(Inline), Op]
        static void _format(byte src, uint maxbits, Span<char> dst, ref int k)
        {
            for(var j=0; j<8; j++, k++)
            {
                if(k>=maxbits)
                    break;
                seek(dst, (uint)k) = @char(@bool(testbit(src, j)));
            }
        }

        [MethodImpl(Inline), Op]
        static void _format(in byte src, int length, uint maxbits, Span<char> dst)
        {
            var k=0;
            for(var i=0u; i<length; i++)
            {
                _format(skip(src,i), maxbits, dst, ref k);
                if(k >= maxbits)
                    break;
            }
        }
    }
}