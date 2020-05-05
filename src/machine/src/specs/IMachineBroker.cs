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

    public interface IMachineBroker : IEventBroker
    {
        AppErrorEvent Error => AppErrorEvent.Empty;   

        LoadedReport LoadedReport => LoadedReport.Empty;

        LoadedParseReport LoadedParseReport => LoadedParseReport.Empty;

        IndexedCode IndexedCode => IndexedCode.Empty;
    }
}