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
        void Deposit(IEnumerable<IAppMsg> msg)
            => Control.iter(msg,Deposit);        

        void Notify(string msg, AppMsgKind? kind = null)
            => Deposit(AppMsg.NoCaller(msg, kind));

        void Displayed(IAppMsg msg)
            => Deposit(msg.AsDisplayed());

        void NotifyConsole(IAppMsg msg, AppMsgColor color)
        {
            if(msg.Kind == AppMsgKind.Error)
                term.print(msg);
            else
                term.print(msg,color);
            
            Displayed(msg);
        }

        void NotifyConsole(IAppMsg msg)
            => NotifyConsole(msg, msg.Color);

        void NotifyConsole(object content, AppMsgColor color)
            => NotifyConsole(AppMsg.NoCaller(content), color);

    }
}