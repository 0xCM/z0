//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    public interface IReportExtractsStep : ICaptureStep
    {
        ExtractReport CreateExtractReport(ApiHostUri host, ExtractedMember[] src);
        
        void SaveExtractReport(ExtractReport src, FilePath dst);
    }
}