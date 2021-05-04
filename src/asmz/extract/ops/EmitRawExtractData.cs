//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    partial class ApiExtractor
    {
        uint EmitRawExtractData(ApiHostUri host, ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var dst = Paths.RawExtractPath(host);
            var packed = CodeBlocks.pack(src);
            HexPacks.Emit(packed, dst);
            return count;
        }
    }
}