//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Konst;
    using static z;

    partial class Multiplex
    {
        [Op]
        public RenderPatternSources PatternSources(Type src)
        {
            var values = src.LiteralFieldValues<string>(out var fields);
            var count = values.Length;
            var buffer = alloc<RenderPatternSource>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new RenderPatternSource(skip(fields,i), skip(values,i));
            return buffer;
        }
    }
}