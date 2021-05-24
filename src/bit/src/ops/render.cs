//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static core;
    using static Typed;

    partial struct bit
    {
        [MethodImpl(Inline), Closures(Closure)]
        public static BitFormatter<T> formatter<T>(BitFormat? config = null)
            where T : struct
                => new BitFormatter<T>(config ?? BitFormat.configure());

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<byte> src, Span<char> dst)
            => render(src, (uint)dst.Length, dst);

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<bit> src, Span<char> dst, uint offset)
        {
            var j = 0u;
            var k = min(src.Length + offset, dst.Length);
            for(uint i=offset; i<k; i++, j++)
                seek(dst,i) = skip(src,j).ToChar();
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, byte src, uint maxbits, uint j, Span<char> dst)
        {
            for(byte i=0; i<8; i++, j++)
            {
                if(j>=maxbits)
                    break;

                seek(dst, (uint)j) = bit.test(src, i).ToChar();
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, in byte src, int length, uint maxbits, Span<char> dst)
        {
            var k=0u;
            for(var i=0u; i<length; i++)
            {
                k += render(n, skip(src,i), maxbits, k, dst);
                if(k >= maxbits)
                    break;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
            => bit.render(n8, first(src), src.Length, maxbits, dst);

        [MethodImpl(Inline), Op]
        public static byte render(N4 n, byte src, uint j, Span<char> dst)
        {
            var counter = z8;
            counter += bit.bitchars(src, 7, out seek(dst, j++), out seek(dst,j++));
            counter += bit.bitchars(src, 5, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bitchars(src, 3, out seek(dst, j++), out seek(dst,j++));
            counter += bitchars(src, 1, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static byte render(N2 n, byte src, uint j, Span<char> dst)
        {
            var counter = z8;

            counter += bitchars(src, 7, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bitchars(src, 5, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bitchars(src, 3, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bitchars(src, 1, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            return counter;
        }

        public static string bitformat(N2 n, byte src)
        {
            Span<char> dst = stackalloc char[12];
            render(n2, src,0, dst);
            return new string(dst);
        }

        [Op]
        public static string format(ReadOnlySpan<bit> src, BitFormat? fmt = null)
        {
            var options = fmt ?? BitFormat.configure();
            var bitcount = min((uint)options.MaxBitCount,(uint)src.Length);
            var blocked = options.BlockWidth != 0;
            var blocks = (uint)(blocked ? src.Length / options.BlockWidth : 0);
            bitcount += blocks; // space for block separators

            Span<char> buffer = stackalloc char[(int)bitcount];
            ref var dst = ref first(buffer);
            var digits = 0;
            for(uint i = 0, j=bitcount-1; i<bitcount; i++, j--)
            {
                if(blocked && digits % options.BlockWidth == 0)
                    seek(dst, j--) = options.BlockSep;

                seek(dst, j) = skip(src,i).ToChar();
                digits++;
            }

            if(options.TrimLeadingZeros)
                return new string(buffer).TrimStart(bit.Zero);
            else
                return new string(buffer);
        }

        [Op]
        public static string format(ReadOnlySpan<byte> src, in BitFormat config)
        {
            var count = src.Length*8;
            var dst = span<char>(count);
            dst.Fill(Chars.D0);

            bit.render(src, config.MaxBitCount, dst);

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

        [Op, Closures(Closure)]
        public static string format<T>(T src)
            where T : struct
                => format(src, BitFormat.configure());

        [Op, Closures(Closure)]
        public static string format<T>(T src, in BitFormat config)
            where T : struct
                => format(bytes(src), config);

        [Op, Closures(Closure)]
        public static string format<T>(ReadOnlySpan<T> src, BitFormat? config = null)
            where T : unmanaged
        {
            var dst = new StringBuilder();
            var cells = src.Length;
            var cfg = config ?? BitFormat.configure();
            for(var i=0; i<cells; i++)
                dst.Append(format<T>(skip(src,i), cfg));
            return dst.ToString();
        }

        [Op, Closures(Closure)]
        public static string format<T>(T src, int? digits = null)
            where T : unmanaged
                => format(src, digits != null ? BitFormat.limited((uint)digits.Value, digits.Value) : BitFormat.configure());

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


        [Op]
        static string format8(object src)
            => bit.formatter<byte>().Format((byte)NumericBox.rebox(src, NumericKind.U8));

        [Op]
        static string format16(object src)
            => bit.formatter<ushort>().Format((ushort)NumericBox.rebox(src, NumericKind.U16));

        [Op]
        static string format32(object src)
            => bit.formatter<uint>().Format((uint)NumericBox.rebox(src, NumericKind.U32));

        [Op]
        static string format64(object src)
            => bit.formatter<ulong>().Format((ulong)NumericBox.rebox(src, NumericKind.U64));
    }
}