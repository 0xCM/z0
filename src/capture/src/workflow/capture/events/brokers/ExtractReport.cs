//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;

    public interface IExtractReportBroker : IEventBroker
    {
        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;        
    }

    public interface IExtractReportClient<C> : IBrokerClient<C>
        where C : IExtractReportBroker
    {
        void OnEvent(ExtractReportCreated e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractReportSaved e) 
            => Sink.Deposit(e);

    }
}