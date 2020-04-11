//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IHostCaptureService : IAsmService
    {
        ParsedExtract[] Parse(MemberExtract[] src);
        
        MemberExtract[] Extract(ApiHostUri host);        

        AsmFunction[] Decode(ApiHostUri host, ParsedExtract[] parsed);        
    }
}
