//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface IHostExtractParseRelay : IWorkflowRelay
    {
        HostExtractsParsed ExtractsParsed => HostExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;
    }


}