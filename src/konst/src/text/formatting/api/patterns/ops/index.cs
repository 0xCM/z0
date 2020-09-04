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

    partial struct RenderPatterns
    {
        [Op]
        public static FormatPatternIndex index(Type src)
        {
            var values = src.LiteralFieldValues<string>(out var fields);
            var count = values.Length;
            var buffer = alloc<FormatPattern>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new FormatPattern(skip(fields,i), skip(values,i));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static FormatPatternIndex index()
            => index(typeof(RenderPatterns));
    }
}