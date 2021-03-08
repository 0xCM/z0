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
        public static string format<T>(in T src)
            where T : struct
        {
            var count = size<T>();
            var dst = span<char>(count*2);
            chars(src,dst);
            return dst.ToString();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void chars<T>(in T src, Span<char> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = root.min(count*2 - 1, dst.Length);
            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = (char)code(LowerCase, UI.crop4(d));
                seek(dst, j--) = (char)code(LowerCase, UI.srl(d, n4, w4));
            }
        }
    }
}