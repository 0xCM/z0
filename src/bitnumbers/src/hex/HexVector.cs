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

    public readonly struct HexVector
    {
        [MethodImpl(Inline), Op]
        public static HexVector8<N4> create(N4 n, W8 w, Span<byte> src)
            => new HexVector8<N4>(recover<Hex8>(src));

        [MethodImpl(Inline), Op]
        public static HexVector16<N4> create(N4 n, W16 w, Span<byte> src)
            => new HexVector16<N4>(recover<Hex16>(src));

        [MethodImpl(Inline), Op]
        public static HexVector8<N4> create(N4 n, N8 w)
            => create(n, w, bytes(0u));

        [MethodImpl(Inline), Op]
        public static HexVector16<N4> create(N4 n, W16 w)
            => create(n, w, bytes(0u));

        [MethodImpl(Inline), Op]
        public static uint bitrender(ReadOnlySpan<Hex8> src, N4 n, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var input = ref skip(src,i);
                j+= bitrender(skip(src,i).Hi, j, dst);
                j+= separate(j,dst);
                j+= bitrender(skip(src,i).Lo, j, dst);
            }
            return j - 1;
        }

        [Op]
        public static uint bitrender(Hex32 src, N8 n, uint offset, Span<char> dst)
        {
            var counter = 0u;
            var x = Hex8.Zero;

            x = src.Hi.Hi;
            counter += bitrender(x, n8, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = src.Hi.Lo;
            counter += bitrender(x, n8, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = src.Lo.Hi;
            counter += bitrender(x, n8, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = src.Lo.Lo;
            counter += bitrender(x, n8, counter + offset, dst);

            return counter;
        }


        [MethodImpl(Inline), Op]
        public static uint bitrender(Hex8 cell, N8 n8, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(cell, 7);
            seek(dst, offset++) = bit.bitchar(cell, 6);
            seek(dst, offset++) = bit.bitchar(cell, 5);
            seek(dst, offset++) = bit.bitchar(cell, 4);
            seek(dst, offset++) = bit.bitchar(cell, 3);
            seek(dst, offset++) = bit.bitchar(cell, 2);
            seek(dst, offset++) = bit.bitchar(cell, 1);
            seek(dst, offset++) = bit.bitchar(cell, 0);
            return 8;
        }

        public static uint bitrender(Hex4 src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(src, 3);
            seek(dst, offset++) = bit.bitchar(src, 2);
            seek(dst, offset++) = bit.bitchar(src, 1);
            seek(dst, offset++) = bit.bitchar(src, 0);
            return 4;
        }

        [MethodImpl(Inline), Op]
        public static uint bitrender(Hex8 cell, N4 n, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(cell, 7);
            seek(dst, offset++) = bit.bitchar(cell, 6);
            seek(dst, offset++) = bit.bitchar(cell, 5);
            seek(dst, offset++) = bit.bitchar(cell, 4);
            offset += separate(offset, dst);
            seek(dst, offset++) = bit.bitchar(cell, 3);
            seek(dst, offset++) = bit.bitchar(cell, 2);
            seek(dst, offset++) = bit.bitchar(cell, 1);
            seek(dst, offset++) = bit.bitchar(cell, 0);
            offset += separate(offset, dst);
            return 10;
        }

        [MethodImpl(Inline), Op]
        static uint separate(uint offset, Span<char> dst)
        {
            seek(dst,offset) = Chars.Space;
            return 1;
        }
    }
}