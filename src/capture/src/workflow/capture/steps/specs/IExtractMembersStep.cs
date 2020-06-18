//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IExtractMembersStep : ICaptureStep
    {
        ApiMember[] LocateMembers(IApiHost host);

        ExtractedMember[] ExtractMembers(IApiHost host);
    }
}