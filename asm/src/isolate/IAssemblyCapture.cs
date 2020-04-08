//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    
    using static AsmWorkflowReports;
    
    public interface IAssemblyCapture : IService
    {
        FiniteSeq<CapturedOp> Capture(PartId src);

        ParsedExtract[] Parse(MemberExtract[] src);
        
        Option<MemberExtractReport> ExtractOps(ApiHost host);        
    }
}
