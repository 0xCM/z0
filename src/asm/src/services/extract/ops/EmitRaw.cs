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

            HexPacks.Emit(Z0.HexPacks.pack(src), PackArchive.RawHexPath(host));
            return count;
        }
    }
}