//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface IAppMsgSink : ISink<IAppMsg>, IAppEnv
    {
        void Deposit(IEnumerable<IAppMsg> msg)
            => Control.iter(msg,Deposit);        

        void Notify(IAppMsg msg)
            => Deposit(msg);

        void Notify(string msg, AppMsgKind? kind = null)
            => Deposit(AppMsg.NoCaller(msg, kind));

        void Displayed(IAppMsg msg)
            => Deposit(msg.AsDisplayed());

        void NotifyConsole(IAppMsg msg)
        {
            if(msg.Kind == AppMsgKind.Error)
                term.print(msg);
            else
                term.print(msg, msg.Color);
            
            Displayed(msg);
        }

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => NotifyConsole(AppMsg.Colorize(content, color));
    }
}