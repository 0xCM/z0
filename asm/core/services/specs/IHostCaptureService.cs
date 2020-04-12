//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IHostCaptureService : IAsmService
    {
        MemberExtract[] Extract(ApiHostUri host, bool save);        

        ParsedExtract[] Parse(ApiHostUri host, MemberExtract[] src, bool save);        

        AsmFunction[] Decode(ApiHostUri host, ParsedExtract[] parsed, bool save);      

        ApiHostCapture CaptureHost(ApiHostUri host, bool save);  
        
    }
}
