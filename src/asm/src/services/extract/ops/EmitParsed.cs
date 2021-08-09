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
        uint EmitParsed(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            var dst = Paths.ParsedHexPath(host);
            var blocks = alloc<MemoryBlock>(count);
            var found = ApiExtracts.terminals(src, blocks);
            var packed = Z0.HexPacks.pack(blocks);
            HexPacks.Emit(packed, dst);
            Wf.Status(string.Format("Identified {0} terminals from {1} methods", found, count));
            return count;
        }
    }
}