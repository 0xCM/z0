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

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static uint render(StringAddress src, ref uint i, Span<char> dst)
        {
            var i0=i;
            ref var c = ref firstchar(src);
            var j=0u;
            while(c != 0)
                seek(dst, i++) = skip(c, j++);
            return j-1;
        }

        [MethodImpl(Inline), Op]
        public static void render(ReadOnlySpan<char> src, ITextBuffer dst)
            => dst.Append(src);

        [MethodImpl(Inline), Op]
        public static void render(ReadOnlySpan<char> src, ITextBuffer dst, bool eol)
        {
            dst.Append(src);
            if(eol)
                dst.Append(RP.Eol);
        }

        [Op]
        public static void render(ReadOnlySpan<string> src, char delimiter, ITextBuffer dst)
        {
            const string DelimitPattern = " {0} ";
            var last = src.Length - 1;
            var count = src.Length;
            var sep = string.Format(DelimitPattern, delimiter);

            for(var i=0; i<count; i++)
            {
                dst.Append(sep);

                ref readonly var s = ref skip(src,i);
                if(i != last)
                    dst.Append(s.PadRight(16));
                else
                    dst.Append(s);
            }
        }
    }
}