//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAssemblyCapture : IService
    {

        ParsedExtract[] Parse(MemberExtract[] src);
        
        Option<MemberExtractReport> ExtractOps(ApiHost host);        
    }
}
