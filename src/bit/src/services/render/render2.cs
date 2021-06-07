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
        public static uint render(N2 n, byte src, ref uint i, Span<AsciCharCode> dst)
        {
            var i0 = i;
            seek(dst, i++) = code(src, 1);
            seek(dst, i++) = code(src, 0);
            return i - i0;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N2 n, byte src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            seek(dst, i++) = bitchar(src, 1);
            seek(dst, i++) = bitchar(src, 0);
            return i - i0;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N2 n, byte src, ref uint i, Span<BitChar> dst)
        {
            var i0 = i;
            seek(dst, i++) = bit.test(src, 1);
            seek(dst, i++) = bit.test(src, 0);
            return i - i0;
        }
    }
}