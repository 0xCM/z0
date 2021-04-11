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
        [Op, Closures(Closure)]
        public static string delimit<T>(T[] src, char delimiter)
            => delimit(@readonly(src), delimiter);

        [Op, Closures(Closure)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter)
            => string.Join($"{delimiter} ", src);

        [Op, Closures(Closure)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter, int pad)
        {
            var dst = text.buffer();
            var count = src.Length;
            var slot = RP.pad(pad);
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                dst.AppendFormat(slot, skip(src,i));
                if(i != last)
                {
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }
            }
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter)
        {
            var dst = build();
            var count = src.Length;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                dst.Append(skip(src,i));

                if(i != last)
                {
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }

            }
            return dst.ToString();
        }

        [Op, Closures(Closure)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter, int pad)
            => delimit(src.ToSpan().ReadOnly(), delimiter, pad);
    }
}