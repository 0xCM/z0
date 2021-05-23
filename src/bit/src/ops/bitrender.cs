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

    partial struct bit
    {
        [MethodImpl(Inline), Op]
        public static byte bitrender(N4 n, byte src, uint j, Span<char> dst)
        {
            var counter = z8;
            counter += bit.bitchars(src, 7, out seek(dst, j++), out seek(dst,j++));
            counter += bit.bitchars(src, 5, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bit.bitchars(src, 3, out seek(dst, j++), out seek(dst,j++));
            counter += bit.bitchars(src, 1, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static byte bitrender(N2 n, byte src, uint j, Span<char> dst)
        {
            var counter = z8;

            counter += bit.bitchars(src, 7, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bit.bitchars(src, 5, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bit.bitchars(src, 3, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            counter += bit.bitchars(src, 1, out seek(dst, j++), out seek(dst,j++));
            seek(dst, j++) = Chars.Space;
            counter++;

            return counter;
        }

        public static string bitformat(N2 n, byte src)
        {
            Span<char> dst = stackalloc char[12];
            bitrender(n2, src,0, dst);
            return new string(dst);
        }
    }
}