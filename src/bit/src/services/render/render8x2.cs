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
    using static bit;

    partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static byte render(N8 n, N2 w, byte src, uint j, Span<char> dst)
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
    }
}