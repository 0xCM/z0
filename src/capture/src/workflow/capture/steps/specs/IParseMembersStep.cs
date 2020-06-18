//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IParseMembersStep : ICaptureStep
    {
        ParsedMember[] ParseExtracts(ApiHostUri host, ExtractedMember[] extracts);

        void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst);
    }
}