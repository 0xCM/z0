//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static AsmWorkflowReports;
    
    public interface IAssemblyCapture : IAsmService
    {
        FiniteSeq<CapturedOp> Capture(AssemblyId src);

        ParsedExtract[] Parse(MemberExtract[] src);
        
        Option<MemberExtractReport> ExtractOps(ApiHost host);        
    }
}
