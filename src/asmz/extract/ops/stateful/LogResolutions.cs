//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial class ApiExtractor
    {
        ReadOnlySpan<ResolvedMethodInfo> LogResolutions(ReadOnlySpan<ResolvedPart> src)
        {
            var methods = ApiResolutions.methods(src);
            var count = methods.Length;
            Wf.Status(string.Format("{0} Resolved {1} methods from {2} parts", Worker(), count, src.Length));
            var buffer = span<ResolvedMethodInfo>(count);
            ApiResolutions.describe(methods, buffer);
            Wf.Status(string.Format("{0} Collected descriptions for {1} method resolutions", Worker(), count));
            TableEmit(buffer, ResolvedMethodInfo.RenderWidths, Db.Table<ResolvedMethodInfo>(SegDir));
            return buffer;
        }
    }
}