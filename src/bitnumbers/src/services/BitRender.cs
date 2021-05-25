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
        [MethodImpl(Inline), Op]
        public static uint render<N>(HexVector8<N> src, in uint offset, Span<char> dst)
            where N : unmanaged, ITypeNat
        {
            var counter = 0u;
            var count = (int)HexVector8<N>.CellCount;
            seek(dst, counter + offset) = Chars.Lt;
            counter++;
            for(int i=count-1; i>=0; i--)
            {
                ref readonly var cell = ref src[i];
                if(i != count-1)
                    counter += separate(counter + offset, dst);

                counter += render(cell, counter + offset, dst);
            }
            seek(dst, counter + offset) = Chars.Gt;
            counter++;
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<Hex8> src, N4 n, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var input = ref skip(src,i);
                j+= render(skip(src,i).Hi, j, dst);
                j+= separate(j,dst);
                j+= render(skip(src,i).Lo, j, dst);
            }
            return j - 1;
        }

        [Op]
        public static uint render(Hex32 src, N8 n, uint offset, Span<char> dst)
        {
            var counter = 0u;
            var x = Hex8.Zero;

            x = src.Hi.Hi;
            counter += render(x, n8, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = src.Hi.Lo;
            counter += render(x, n8, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = src.Lo.Hi;
            counter += render(x, n8, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = src.Lo.Lo;
            counter += render(x, n8, counter + offset, dst);

            return counter;
        }


        [MethodImpl(Inline), Op]
        public static uint render(Hex8 cell, N8 n8, uint offset, Span<char> dst)
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

        public static uint render(Hex4 src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(src, 3);
            seek(dst, offset++) = bit.bitchar(src, 2);
            seek(dst, offset++) = bit.bitchar(src, 1);
            seek(dst, offset++) = bit.bitchar(src, 0);
            return 4;
        }

        [MethodImpl(Inline), Op]
        public static uint render(Hex8 cell, uint offset, Span<char> dst)
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

        [MethodImpl(Inline), Op]
        public static uint render(Hex8 cell, N4 n, uint offset, Span<char> dst)
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