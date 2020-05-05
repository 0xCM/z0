//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static MachineEvents;

    public interface ILoadedReport : IEventBroker
    {
        LoadedReport LoadedReport => LoadedReport.Empty;

        LoadedParseReport LoadedParseReport => LoadedParseReport.Empty;
    }
}
