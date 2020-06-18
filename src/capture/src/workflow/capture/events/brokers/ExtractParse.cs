//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;
    using static ExtractEvents;

    public interface IExtractParseBroker : IEventBroker
    {
        ExtractParseFailed ExtractParseFailed => ExtractParseFailed.Empty;

        ExtractsParsed ExtractsParsed => ExtractsParsed.Empty;            
        
        ParseReportCreated ParseReportCreated => ParseReportCreated.Empty;
    }

    public interface IExtractParseClient<C> : IBrokerClient<C>
        where C : IExtractParseBroker
    {
        void OnEvent(ExtractParseFailed e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractsParsed e) 
            => Sink.Deposit(e);

        void OnEvent(ParseReportCreated e) 
            => Sink.Deposit(e);
    }
}