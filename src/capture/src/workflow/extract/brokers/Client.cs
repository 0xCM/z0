//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CaptureWorkflowEvents;
    using static ExtractionEvents;

    public interface IExtractionBrokerClient : IBrokerClient<IExtractionBroker>
    {
        void OnEvent(AppErrorEvent e) { }

        void OnEvent(MembersLocated e) { }

        void OnEvent(MembersExtracted e) { }

        void OnEvent(ExtractReportCreated e) { }

        void OnEvent(ExtractReportSaved e) { }

        void OnEvent(AnalyzingExtractReport e) { }

        void Connect()
        {
            Broker.Error.Subscribe(Broker, OnEvent);
            Broker.MembersLocated.Subscribe(Broker, OnEvent);
            Broker.MembersExtracted.Subscribe(Broker, OnEvent);
            Broker.ExtractReportCreated.Subscribe(Broker, OnEvent);
            Broker.ExtractReportSaved.Subscribe(Broker, OnEvent);
            Broker.AnalyzingExtractReport.Subscribe(Broker, OnEvent);
        }        
    }

    public readonly struct ExtractionBrokerClient : IExtractionBrokerClient
    {
        [MethodImpl(Inline)]
        public static IExtractionBrokerClient Create(IExtractionBroker broker, IAppMsgSink sink, bool connect = true)
            => new ExtractionBrokerClient(broker, sink,connect);

        public IExtractionBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        [MethodImpl(Inline)]
        public ExtractionBrokerClient(IExtractionBroker broker, IAppMsgSink sink, bool connect)
        {
            Broker = broker;
            Sink = sink;
            if(connect)
                (this as IExtractionBrokerClient).Connect();
        }
    }
}