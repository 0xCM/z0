//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;

    public interface IHostExtractParseBroker : IEventBroker
    {
        HostExtractsParsed ExtractsParsed => HostExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;
    }
}