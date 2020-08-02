//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IEventBrokerPattern : IEventBroker
    {
        MembersLocated MembersLocated => MembersLocated.Empty;

        MembersExtracted MembersExtracted => MembersExtracted.Empty;

        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;

        AnalyzingExtractReport AnalyzingExtractReport => AnalyzingExtractReport.Empty;
    }

    public interface IBrokerClientPattern : IBrokerClient<IEventBrokerPattern>
    {
        void OnEvent(MembersLocated e) 
            => Sink.Deposit(e);

        void OnEvent(MembersExtracted e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractReportCreated e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractReportSaved e) 
            => Sink.Deposit(e);

        void OnEvent(AnalyzingExtractReport e) 
            => Sink.Deposit(e);

        void Connect()
        {
            Broker.MembersLocated.Subscribe(Broker, OnEvent);
            Broker.MembersExtracted.Subscribe(Broker, OnEvent);
            Broker.ExtractReportCreated.Subscribe(Broker, OnEvent);
            Broker.ExtractReportSaved.Subscribe(Broker, OnEvent);
            Broker.AnalyzingExtractReport.Subscribe(Broker, OnEvent);
        }        
    }

    public readonly struct BrokerClientPattern : IBrokerClientPattern
    {
        public IEventBrokerPattern Broker {get;}

        public IAppMsgSink Sink {get;}

        [MethodImpl(Inline)]
        public BrokerClientPattern(IEventBrokerPattern broker, IAppMsgSink sink, bool connect)
        {
            Broker = broker;
            Sink = sink;
            if(connect)
                (this as IBrokerClientPattern).Connect();
        }
    }
}