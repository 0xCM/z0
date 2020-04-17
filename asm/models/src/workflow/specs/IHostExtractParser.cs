//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IHostExtractParser : IService
    {
        ParsedExtract[] ParseExtracts(ApiHostUri host, ExtractedMember[] extracts);

        void SaveHex(ApiHostUri host, ParsedExtract[] src, FilePath dst);

    }
}