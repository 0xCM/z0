//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Render
    {
        [MethodImpl(Inline), Op]
        public static void bits(in byte src, int length, uint maxbits, Span<char> dst)
        {
            var k=0;
            for(var i=0u; i<length; i++)
            {
                bits(skip(src,i), maxbits, dst, ref k);
                if(k >= maxbits)
                    break;
            }
        }

        [MethodImpl(Inline), Op]
        public static void bits(ReadOnlySpan<byte> src, Count maxbits, Span<char> dst)
            => bits(first(src), src.Length, maxbits, dst);

        [Op]
        public static ReadOnlySpan<char> bitchars(byte[] src)
        {
            var dst = span<char>(src.Length*8);
            var input = span(src);
            var config = BitFormat.Default;
            bits(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void bits(byte[] src, Span<char> dst)
        {
            var input = span(src);
            var config = BitFormat.Default;
            bits(src, dst.Length, dst);
        }

        [MethodImpl(Inline), Op]
        public static string bits(object src, TypeCode type)
        {
            if(type == TypeCode.Byte || type == TypeCode.SByte)
                return Formatters.bits<byte>().Format((byte)rebox(src, NumericKind.U8));
            else if(type == TypeCode.UInt16 || type == TypeCode.Int16)
                return Formatters.bits<ushort>().Format((ushort)rebox(src, NumericKind.U16));
            else if(type == TypeCode.UInt32  || type == TypeCode.Int32 || type == TypeCode.Single)
                return Formatters.bits<uint>().Format((uint)rebox(src, NumericKind.U32));
            else if(type == TypeCode.UInt64 || type == TypeCode.Int64 || type == TypeCode.Double)
                return Formatters.bits<ulong>().Format((ulong)rebox(src, NumericKind.U64));
            else
                return EmptyString;
        }

        [MethodImpl(Inline), Op]
        public static void bits(byte src, uint maxbits, Span<char> dst, ref int k)
        {
            for(var j=0; j<8; j++, k++)
            {
                if(k>=maxbits)
                    break;
                seek(dst, (uint)k) = @char(@bool(testbit(src, j)));
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string bits<T>(T src)
            where T : struct
                => bits(src, BitFormatter.configure());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string bits<T>(T src, in BitFormat config)
            where T : struct
                => bits(bytes(src), config);

        [Op]
        public static string bits(ReadOnlySpan<byte> src, in BitFormat config)
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
    }
}