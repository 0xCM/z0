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
        
        ParseReportEmitted ParseReportCreated => ParseReportEmitted.Empty;
    }

    public interface IExtractParseClient<C> : IBrokerClient<C>
        where C : IExtractParseBroker
    {
        void OnEvent(ExtractParseFailed e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractsParsed e) 
            => Sink.Deposit(e);

        void OnEvent(ParseReportEmitted e) 
            => Sink.Deposit(e);
    }
}