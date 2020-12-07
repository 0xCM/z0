//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    partial class text
    {
        [Op, Closures(UnsignedInts)]
        public static string delimit<T>(T[] items, char delimiter)
        {
            var dst = text.build();
            var src = @readonly(items);
            var count = src.Length;
            var sep = text.format(" {0} ", delimiter);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(sep);
                dst.Append(skip(src,i));
            }
            return dst.ToString();
        }

        [Op]
        public static string nest(params object[] src)
            => text.format(RP.SSx5,
                FieldDelimiter,
                NestedLeftFence,
                text.concat(src.Select(x => delimit(src,FieldDelimiter))),
                NestedRightFence,
                FieldDelimiter
                );

    }
}