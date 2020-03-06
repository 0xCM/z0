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

        ParsedExtract[] Parse(OpExtract[] src);
        
        Option<OpExtractReport> ExtractOps(ApiHost host);        

    }

}
