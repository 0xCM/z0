//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface IAppMsgSink : ISink<IAppMsg>
    {
        void Deposit(IEnumerable<IAppMsg> msg);

        void Notify(IAppMsg msg);

        void Notify(string msg, AppMsgKind? kind = null);

        void Displayed(IAppMsg msg);

        void NotifyConsole(IAppMsg msg, AppMsgColor color);

        void NotifyConsole(IAppMsg msg);

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green);            
    }
}