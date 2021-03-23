//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Hex
    {
        [Op, Closures(Closure)]
        public static ReadOnlySpan<HexCodeLo> digits<T>(in T src, LowerCased @case)
            where T : struct
        {
            var count = size<T>();
            var dst = span<HexCodeLo>(count*2);
            digits(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void digits<T>(in T src, Span<HexCodeLo> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = code(LowerCase, BitNumbers.uint4(d));
                seek(dst, j--) = code(LowerCase, BitNumbers.srl(d, n4, w4));
            }
        }
    }
}