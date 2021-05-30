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
    using static Typed;

    [ApiHost]
    public readonly struct BitRender
    {
        const byte CellWidth = 16;

        [MethodImpl(Inline), Op]
        public static byte hi(byte src)
            => (byte)((byte)src >> 4);

        [MethodImpl(Inline), Op]
        public static byte hi(ushort src)
            => (byte)(src >> 8);

        [MethodImpl(Inline), Op]
        public static ushort hi(uint src)
            => (ushort)(src >> 16);

        [MethodImpl(Inline), Op]
        public static uint hi(ulong src)
            => (uint)(src >> 32);

        [MethodImpl(Inline), Op]
        public static byte lo(byte src)
            => (byte)((byte)src & 0xF);

        [MethodImpl(Inline), Op]
        public static byte lo(ushort src)
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static ushort lo(uint src)
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static uint lo(ulong src)
            => (uint)src;

        public static uint render<N>(N8 n, N8 w, ReadOnlySpan<byte> src, uint offset, Span<char> dst)
            where N : unmanaged, ITypeNat
        {
            var counter = 0u;
            var count = (int)NatValues.value<N>();
            seek(dst, counter + offset) = Chars.Lt;
            counter++;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref src[i];
                if(i != 0)
                    counter += separate(counter + offset, dst);

                counter += render(n8, cell, counter + offset, dst);
            }
            seek(dst, counter + offset) = Chars.Gt;
            counter++;
            return counter;
        }

        [Op]
        public static uint render(N32 n, N8 w, uint src, uint offset, Span<char> dst)
        {
            var counter = 0u;
            var x = z8;

            var cells = bytes(src);
            x = skip(cells,0);
            counter += render(w, x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,1);
            counter += render(w, x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,2);
            counter += render(w, x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,3);
            counter += render(w, x, counter + offset, dst);

            return counter;
        }

        public static uint render(N8 n, N4 w, ReadOnlySpan<byte> src, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var input = ref skip(src,i);
                j+= render(w, w, hi(skip(src,i)), j, dst);
                j+= separate(j, dst);
                j+= render(w, w, lo(skip(src,i)), j, dst);
            }
            return j - 1;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N4 w, byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(src, 7);
            seek(dst, offset++) = bit.bitchar(src, 6);
            seek(dst, offset++) = bit.bitchar(src, 5);
            seek(dst, offset++) = bit.bitchar(src, 4);
            offset += separate(offset, dst);
            seek(dst, offset++) = bit.bitchar(src, 3);
            seek(dst, offset++) = bit.bitchar(src, 2);
            seek(dst, offset++) = bit.bitchar(src, 1);
            seek(dst, offset++) = bit.bitchar(src, 0);
            offset += separate(offset, dst);
            return n + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N4 n, N4 w, byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(src, 3);
            seek(dst, offset++) = bit.bitchar(src, 2);
            seek(dst, offset++) = bit.bitchar(src, 1);
            seek(dst, offset++) = bit.bitchar(src, 0);
            return n;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(src, 7);
            seek(dst, offset++) = bit.bitchar(src, 6);
            seek(dst, offset++) = bit.bitchar(src, 5);
            seek(dst, offset++) = bit.bitchar(src, 4);
            seek(dst, offset++) = bit.bitchar(src, 3);
            seek(dst, offset++) = bit.bitchar(src, 2);
            seek(dst, offset++) = bit.bitchar(src, 1);
            seek(dst, offset++) = bit.bitchar(src, 0);
            return n;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N16 n, ushort src, uint maxbits, uint j, Span<char> dst)
        {
            var count = CellWidth;
            for(byte i=0; i<count; i++, j++)
            {
                if(j>=maxbits)
                    break;

                seek(dst, (uint)j) = bit.test(src, i).ToChar();
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N16 n, in ushort src, int length, uint maxbits, Span<char> dst)
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
        public static uint render(ReadOnlySpan<ushort> src, uint maxbits, Span<char> dst)
            => render(n16, first(src), src.Length, maxbits, dst);

        [Op]
        public static string format(N32 n, N8 w, uint src)
        {
            Span<char> buffer = stackalloc char[64];
            var count = render(n, w, src, 0, buffer);
            return new string(slice(buffer,0,count));
        }

        public static string format(ReadOnlySpan<ushort> src, in BitFormat config)
        {
            var count = src.Length*CellWidth;
            var dst = span<char>(count);
            dst.Fill(Chars.D0);

            render(src, config.MaxBitCount, dst);

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
        static uint separate(uint offset, Span<char> dst)
        {
            seek(dst,offset) = Chars.Space;
            return 1;
        }
    }
}