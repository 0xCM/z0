//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class ApiExtractor
    {
        uint EmitRaw(ApiHostUri host, ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            HexPacks.Emit(HexPacking.hexpack(src), Paths.RawExtractPath(host));
            return count;
        }
    }
}