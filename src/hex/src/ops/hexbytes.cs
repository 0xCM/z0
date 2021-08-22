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

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static uint hexbytes(Hex64 src, LowerCased @case, Span<char> dst)
        {
            var i=0u;
            var data = bytes(src);
            var count = data.Length;
            for(var j=0; j<count; j++)
            {
                ref readonly var b = ref skip(data, j);
                render(@case, (Hex8)b, ref i, dst);
                if(j != count - 1)
                    seek(dst, i++) = Chars.Space;
            }
            return i;
        }

        [MethodImpl(Inline), Op]
        public static CharBlock24 hexbytes(Hex64 src, LowerCased @case)
        {
            var dst = CharBlock24.Null;
            hexbytes(src, @case, dst.Data);
            return dst;
        }
    }
}