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

    partial struct Lines
    {
        [Op]
        public static string format(in LineNumber src)
            => string.Format(LineNumber.RenderPattern, src.Value);

        [Op]
        public static string format(in AsciLine src)
        {
            if(src.IsEmpty)
                return format(src.LineNumber);
            else
            {
                Span<char> buffer = stackalloc char[src.RenderLength];
                var i=0u;
                render(src, ref i, buffer);
                return text.format(buffer);
            }
        }

        [Op]
        public static string format(in UnicodeLine src)
        {
            if(src.IsEmpty)
                return format(src.LineNumber);
            else
            {
                Span<char> buffer = stackalloc char[src.RenderLength];
                var i=0u;
                render(src, ref i, buffer);
                return text.format(buffer);
            }
        }
    }
}