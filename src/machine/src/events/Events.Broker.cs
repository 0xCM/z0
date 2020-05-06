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

    public interface IMachineEvents : IBrokerClient
    {
        AppErrorEvent Error => AppErrorEvent.Empty;   

        void OnEvent(AppErrorEvent e)  => Sink.Deposit(e);

        LoadedReport LoadedReport => LoadedReport.Empty;

        void OnEvent(LoadedReport e)  => Sink.Deposit(e);

        LoadedParseReport LoadedParseReport => LoadedParseReport.Empty;

        void OnEvent(LoadedParseReport e)  => Sink.Deposit(e);

        IndexedCode IndexedCode => IndexedCode.Empty;

        void OnEvent(IndexedCode e)  => Sink.Deposit(e);

        DecodedHost DecodedHost => DecodedHost.Empty;

        void OnEvent(DecodedHost e)  => Sink.Deposit(e);

        DecodedIndex DecodedIndex => DecodedIndex.Empty;

        void OnEvent(DecodedIndex e)  => Sink.Deposit(e);

        void Connect();

    }

}