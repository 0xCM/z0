//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    partial class ApiExtractor
    {
        ReadOnlySpan<ResolvedPart> ResolveParts(ReadOnlySpan<PartId> src)
        {
            var flow = Wf.Running(string.Format("{0} Resolving parts [{1}]", Worker(), src.Delimit(Chars.Comma).Format()));
            var count = src.Length;
            var buffer = alloc<ResolvedPart>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst, i) = ResolvePart(skip(src, i));
            Wf.Ran(flow);
            return buffer;
        }
    }
}