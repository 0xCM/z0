//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{ 
    public interface IMachineClient : IWfBrokerClient
    {
        WfError Error => default;
        
        LoadedParseReport LoadedParseReport => default;

        IndexedEncoded IndexedCode => default;

        DecodedHost DecodedHost => default;

        DecodedPart DecodedPart => default;

        DecodedMachine DecodedIndex => default;

        void OnEvent(WfError e) 
            => Sink.Deposit(e);

        void OnEvent(LoadedParseReport e) 
            => Sink.Deposit(e);

        void OnEvent(IndexedEncoded e) 
            => Sink.Deposit(e);

        void OnEvent(DecodedHost e) 
            => Sink.Deposit(e);

        void OnEvent(DecodedPart e) 
            => Sink.Deposit(e);

        void OnEvent(DecodedMachine e) 
            => Sink.Deposit(e);

        void Connect()
        {
            Error.Subscribe(Broker,OnEvent);            
            LoadedParseReport.Subscribe(Broker,OnEvent);
            IndexedCode.Subscribe(Broker,OnEvent);
            DecodedHost.Subscribe(Broker,OnEvent);
            DecodedPart.Subscribe(Broker,OnEvent);
            DecodedIndex.Subscribe(Broker,OnEvent);
        }        
    }
}