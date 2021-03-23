//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static TextRules;
    using static memory;

    partial class text
    {
        [MethodImpl(Inline)]
        public static string delimit<T>(T[] src, char delimiter)
            => Format.delimit(src, delimiter);

        [MethodImpl(Inline)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter)
            => Format.delimit(src, delimiter);

        [MethodImpl(Inline)]
        public static string nest(params object[] src)
            => Format.nest(src);

        [Op]
        public static string delimit(ReadOnlySpan<string> src, char delimiter)
        {
            var dst = text.buffer();
            var last = src.Length - 1;
            var count = src.Length;
            var sep = string.Format(" {0} ", delimiter);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(sep);

                dst.Append(skip(src,i));
            }

            return dst.Emit();
        }
    }
}