//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    public interface IAppMsgReceiver : IService
    {
        IAppMsgSink Sink {get;}

        void Report(IAppEvent e, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(e.Format(), color);        
    }
}