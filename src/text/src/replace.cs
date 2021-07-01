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

    partial class text
    {
       [Op]
        public static string replace(string src, char a, char b)
            => src.Replace(a,b);

        [MethodImpl(Inline), Op]
        public static void replace(Span<char> src, char a, char b)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(skip(src,i) == a)
                    seek(src,i) = b;
        }

        [MethodImpl(Inline), Op]
        public static void replace(ReadOnlySpan<char> src, char a, char b, Span<char> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                seek(dst,i) = equals(c,a) ? b : c;
            }
        }
    }
}