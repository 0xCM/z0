//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHostExtractParser : IService
    {
        ParsedMemberExtract[] ParseExtracts(ApiHostUri host, MemberExtract[] extracts);

        void SaveHex(ApiHostUri host, ParsedMemberExtract[] src, FilePath dst);

    }
}