//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.Asm;

    partial class ApiExtractor
    {
        uint EmitRawExtractData(ApiHostUri host, ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            HexPacks.Emit(CodeBlocks.hexpack(src), Paths.RawExtractPath(host));
            return count;
        }
    }
}