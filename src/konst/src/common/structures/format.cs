//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Structures
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static string format<T>(in T src)
            where T : struct
        {
            var count = size<T>();
            var dst = span<char>(count*2);
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = (char)Hex.code(LowerCase, Unsigned.cut(d, w4));
                seek(dst, j--) = (char)Hex.code(LowerCase, Unsigned.srl(d, n4, w4));
            }

            return text.format(dst);
        }
    }
}