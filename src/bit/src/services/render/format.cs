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

    partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static string format(N2 n, byte src)
        {
            var i=0u;
            var buffer = CharBlock2.Null;
            var dst = buffer.Data;
            render(n, src, ref i, dst);
            return new string(dst);
        }

        [Op]
        public static string format(N3 n, byte src)
        {
            var buffer = CharBlock3.Null.Data;
            var i=0u;
            var count = render(n, src, ref i, buffer);
            return new string(slice(buffer,0,count));
        }

        [Op]
        public static string format(N4 n, byte src)
        {
            var buffer = CharBlock4.Null.Data;
            var i=0u;
            var count = render(n, src, ref i, buffer);
            return new string(slice(buffer,0,count));
        }

        [Op]
        public static string format(N5 n, byte src)
        {
            var buffer = CharBlock5.Null.Data;
            var i=0u;
            var count = render(n, src, ref i, buffer);
            return new string(slice(buffer,0,count));
        }

        [Op]
        public static string format(N6 n, byte src)
        {
            var buffer = CharBlock6.Null.Data;
            var i=0u;
            var count = render(n, src, ref i, buffer);
            return new string(slice(buffer,0,count));
        }

        [Op]
        public static string format(N7 n, byte src)
        {
            var buffer = CharBlock7.Null.Data;
            var i=0u;
            var count = render(n, src, ref i, buffer);
            return new string(slice(buffer,0,count));
        }

        [Op]
        public static string format(N8 n, byte src)
        {
            var buffer = CharBlock8.Null.Data;
            var i=0u;
            var count = render(n, src, ref i, buffer);
            return new string(slice(buffer,0,count));
        }

        [Op]
        public static string format(N32 n, N8 w, uint src)
        {
            var buffer = CharBlock64.Null.Data;
            var count = render(n, w, src, 0, buffer);
            return new string(slice(buffer,0,count));
        }

        public static string format(ReadOnlySpan<byte> src, in BitFormat config)
        {
            var count = src.Length*8;
            var dst = span<char>(count);
            dst.Fill(Chars.D0);

            BitRender.render8x8(src, config.MaxBitCount, dst);

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

        public static string format(ReadOnlySpan<bit> src, BitFormat? fmt = null)
        {
            var options = fmt ?? BitFormat.configure();
            var bitcount = min((uint)options.MaxBitCount,(uint)src.Length);
            var blocked = options.BlockWidth != 0;
            var blocks = (uint)(blocked ? src.Length/options.BlockWidth : 0);
            bitcount += blocks; // space for block separators

            Span<char> buffer = stackalloc char[(int)bitcount];
            ref var dst = ref first(buffer);
            var digits = 0;
            for(uint i = 0, j=bitcount-1; i<bitcount; i++, j--)
            {
                if(blocked && (digits % options.BlockWidth) == 0)
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
            => BitRender.formatter<byte>().Format((byte)NumericBox.rebox(src, NumericKind.U8));

        [Op]
        static string format16(object src)
            => BitRender.formatter<ushort>().Format((ushort)NumericBox.rebox(src, NumericKind.U16));

        [Op]
        static string format32(object src)
            => BitRender.formatter<uint>().Format((uint)NumericBox.rebox(src, NumericKind.U32));

        [Op]
        static string format64(object src)
            => BitRender.formatter<ulong>().Format((ulong)NumericBox.rebox(src, NumericKind.U64));
    }
}