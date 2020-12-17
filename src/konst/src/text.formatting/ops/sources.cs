//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct TextFormatter
    {
        [Op]
        public static RenderPatternSources sources(Type src)
        {
            var values = src.LiteralFieldValues<string>(out var fields);
            var count = values.Length;
            var buffer = sys.alloc<RenderPatternSource>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new RenderPatternSource(skip(fields,i), skip(values,i));
            return buffer;
        }
    }
}