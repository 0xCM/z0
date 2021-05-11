//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial class ApiExtractor
    {
        uint EmitParsedExtractData(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            var dst = Paths.ParsedExtractPath(host);
            var blocks = alloc<MemoryBlock>(count);
            var found = terminals(src, blocks);
            var packed = Hex.hexpack(blocks);
            HexPacks.Emit(packed, dst);
            Wf.Status(string.Format("Identified {0} terminals from {1} methods", found, count));
            return count;
        }

    }
}