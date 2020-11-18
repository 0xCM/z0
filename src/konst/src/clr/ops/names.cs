//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ClrQuery
    {
        [Op]
        public static Z0.EnumLiteralNames[] names(ReadOnlySpan<ClrEnum> src)
        {
            var count = src.Length;
            var buffer = z.alloc<Z0.EnumLiteralNames>(count);
            var dst  = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var et = ref skip(src,i);
                seek(dst,i) = new Z0.EnumLiteralNames(et, System.Enum.GetNames(et));
            }

            return buffer;
        }
    }
}