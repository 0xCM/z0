//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IAssemblyCapture : IAsmService
    {
        FiniteSeq<CapturedOp> Capture(AssemblyId src);

        ParsedExtract[] Parse(MemberExtract[] src);
        
        Option<MemberExtractReport> ExtractOps(ApiHost host);        

    }

}
