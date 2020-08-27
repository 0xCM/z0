//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMachineClient : IWfBrokerClient
    {
        IWfError Error => default(WfError<object>);

        LoadedParseReport LoadedParseReport => default;

        DecodedHost DecodedHost => default;

        void OnEvent(IWfError e)
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
            DecodedHost.Subscribe(Broker,OnEvent);
        }
    }
}