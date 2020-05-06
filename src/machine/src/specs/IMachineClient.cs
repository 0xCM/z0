//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MachineEvents;

    public interface IMachineClient : IBrokerClient
    {
        void OnEvent(AppErrorEvent e) 
            => Sink.Deposit(e);

        void OnEvent(LoadedReport e) 
            => Sink.Deposit(e);

        void OnEvent(LoadedParseReport e) 
            => Sink.Deposit(e);

        void OnEvent(IndexedCode e) 
            => Sink.Deposit(e);

        void OnEvent(DecodedEncoded e) 
            => Sink.Deposit(e);

        void Connect();
    }

    public interface IMachineClient<C> : IMachineClient, IBrokerClient<C>
        where C : IMachineBroker
    {
        void IMachineClient.Connect()
        {
            Broker.Error.Subscribe(Broker,OnEvent);            
            Broker.LoadedReport.Subscribe(Broker,OnEvent);
            Broker.LoadedParseReport.Subscribe(Broker,OnEvent);
            Broker.IndexedCode.Subscribe(Broker,OnEvent);
            Broker.DecodedEncoded.Subscribe(Broker,OnEvent);
        }        
    }
}