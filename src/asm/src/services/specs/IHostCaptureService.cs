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
        MemberExtract[] Extract(ApiHostUri host, bool save);        

        ParsedMember[] Parse(ApiHostUri host, MemberExtract[] src, bool save);        

        AsmFunction[] Decode(ApiHostUri host, ParsedMember[] parsed, bool save);      

        HostCapture CaptureHost(ApiHostUri host, bool save);        
    }
}