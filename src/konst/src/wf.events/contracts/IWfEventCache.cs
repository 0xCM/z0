//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IWfEventCache : IWfEventSink
    {
        bool Take(out IWfEvent e);

        uint Take(Span<IWfEvent> dst);

        IEnumerable<IWfEvent> Take();
    }
}