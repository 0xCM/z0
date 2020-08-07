//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ICaptureClient : IWfBrokerClient<ICaptureBroker>
    {
        void OnEvent(IWfError e)
            => Sink.Deposit(e);
        
        void OnEvent(WfStatus e) 
            => Sink.Deposit(e);

        void OnEvent(CapturingPart e) 
            => Sink.Deposit(e);

        void OnEvent(CapturingHost e) 
            => Sink.Deposit(e);

        void OnEvent(CapturedHost e) 
            => Sink.Deposit(e);

        void OnEvent(CapturedPart e) 
            => Sink.Deposit(e);            

        void OnEvent(ExtractParseFailed e) 
            => Sink.Deposit(e);

        void OnEvent(ExtractsParsed e) 
            => Sink.Deposit(e);

        void OnEvent(EmittedParseReport e) 
            => Sink.Deposit(e);

        void OnEvent<T>(WfError<T> e) 
            => Sink.Deposit(e);        

        void OnEvent<T>(WfStatus<T> e) 
            => Sink.Deposit(e);        

        void OnEvent(HexCodeSaved e) 
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
            
        void OnEvent(ExtractedMembers e) 
            => Sink.Deposit(e);            

        void OnEvent(CapturingHosts e) 
            => Sink.Deposit(e);            

        void OnEvent(ClearedPartFiles e)
            => Sink.Deposit(e);

        void Connect()
        {
            Broker.Status.Subscribe(Broker,OnEvent);
            Broker.Error.Subscribe(Broker,OnEvent);
            Broker.CapturingPart.Subscribe(Broker, OnEvent);
            Broker.CapturedPart.Subscribe(Broker, OnEvent);            
            Broker.CapturingHost.Subscribe(Broker, OnEvent);
            Broker.CapturedHost.Subscribe(Broker, OnEvent);
            Broker.MembersLocated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportCreated.Subscribe(Broker,OnEvent);
            Broker.ExtractReportSaved.Subscribe(Broker,OnEvent);
            Broker.ParseReportCreated.Subscribe(Broker, OnEvent);
            Broker.ClearedPartFiles.Subscribe(Broker, OnEvent);
            Broker.FunctionsDecoded.Subscribe(Broker, OnEvent);
            Broker.HexSaved.Subscribe(Broker,OnEvent);
            Broker.ExtractsParsed.Subscribe(Broker,OnEvent);
            Broker.ExtractParseFailed.Subscribe(Broker,OnEvent);
            Broker.MatchedEmissions.Subscribe(Broker, OnEvent);
            Broker.ClearedDirectory.Subscribe(Broker, OnEvent);
            Broker.ExtractedMembers.Subscribe(Broker, OnEvent); 
            Broker.CapturingHosts.Subscribe(Broker, OnEvent);         
        }        
    }
}