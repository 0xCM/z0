//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct CaptureClient : ICaptureClient
    {
        public ICaptureBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        [MethodImpl(Inline)]
        public CaptureClient(ICaptureBroker broker, IAppMsgSink sink, bool connect)
        {
            Broker = broker;
            Sink = sink;
            if(connect)
                ((ICaptureClient)this).Connect();
        }
    }    
    
    public interface ICaptureClient : IBrokerClient<ICaptureBroker>
    {
        void OnEvent(ExtractParseFailed e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractsParsed e) 
            => Sink.Deposit(e);

        void OnEvent(ParseReportEmitted e) 
            => Sink.Deposit(e);

        void OnEvent(HexCodeSaved e) 
            => Sink.Deposit(e);        

        void OnEvent(AppErrorEvent e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractReportCreated e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractReportSaved e) 
            => Sink.Deposit(e);
        
        void OnEvent(MembersLocated e) 
            => Sink.Deposit(e);

        void OnEvent(FunctionsDecoded e) 
            => Sink.Deposit(e);

        void OnEvent(ClearedDirectory e) 
            => Sink.Deposit(e);

        void OnEvent(MatchedCapturedEmissions e) 
            => Sink.Deposit(e);

        void OnEvent(CapturingPart e) 
            => Sink.Deposit(e);

        void OnEvent(CapturedPart e) 
            => Sink.Deposit(e);            

        void OnEvent(ExtractedMembers e) 
            => Sink.Deposit(e);            

        void Connect()
        {
            //Broker.Error.Subscribe(Broker,OnEvent);
            Broker.MembersLocated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportCreated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportSaved.Subscribe(Broker,OnEvent);
            Broker.ParseReportCreated.Subscribe(Broker, OnEvent);
            Broker.FunctionsDecoded.Subscribe(Broker, OnEvent);
            Broker.HexSaved.Subscribe(Broker,OnEvent);
            Broker.ExtractsParsed.Subscribe(Broker,OnEvent);
            Broker.ExtractParseFailed.Subscribe(Broker,OnEvent);
            Broker.MatchedEmissions.Subscribe(Broker, OnEvent);
            Broker.CapturingPart.Subscribe(Broker, OnEvent);
            Broker.CapturedPart.Subscribe(Broker, OnEvent);
            Broker.ClearedDirectory.Subscribe(Broker, OnEvent);
        }        
    }
}