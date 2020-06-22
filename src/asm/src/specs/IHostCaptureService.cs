//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Characterizes host-centric capture service operations
    /// </summary>
    public interface IHostCaptureService : IAppMsgContext
    {
        ExtractedCode[] Extract(ApiHostUri host, bool save);        

        ParsedExtract[] Parse(ApiHostUri host, ExtractedCode[] src, bool save);        

        AsmFunction[] Decode(ApiHostUri host, ParsedExtract[] parsed, bool save);      

        CapturedHost CaptureHost(ApiHostUri host, bool save);        
    }
}