//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct TextFormatter
    {
        [Op]
        public static string format(ReadOnlySpan<string> src, char delimiter)
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
    }
}