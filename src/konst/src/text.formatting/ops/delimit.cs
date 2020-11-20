//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Render
    {
        [Op]
        public static string delimit(ReadOnlySpan<string> src, char delimiter)
        {
            var dst = text.build();
            var last = src.Length - 1;
            var count = src.Length;
            var sep = string.Format(" {0} ", delimiter);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(sep);

                ref readonly var s = ref skip(src,i);

                if(i != last)
                    dst.Append(s.PadRight(16));
                else
                    dst.Append(s);
            }

            return dst.ToString();
        }

        [Op]
        public static void delimit(ReadOnlySpan<string> src, char delimiter, ITextBuffer dst)
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