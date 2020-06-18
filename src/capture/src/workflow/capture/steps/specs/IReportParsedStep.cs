//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IReportParsedStep : ICaptureStep
    {
        MemberParseReport CreateParseReport(ApiHostUri host, ParsedMember[] src);        

        void SaveParseReport(MemberParseReport src, FilePath dst);
    }
}