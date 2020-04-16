//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface IHostExtractParseRelay : 
        IEventBroker<HostExtractsParsed>, 
        IEventBroker<ParseReportCreated>
    {
        HostExtractsParsed ExtractsParsed => HostExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;
    }


}