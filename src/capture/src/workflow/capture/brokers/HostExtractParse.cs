//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;
    using static ExtractEvents;

    public interface IHostExtractParseBroker : IEventBroker
    {
        ExtractParseFailed ExtractParseFailed => ExtractParseFailed.Empty;

        HostExtractsParsed ExtractsParsed => HostExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;
    }
}