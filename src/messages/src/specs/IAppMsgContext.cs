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

    public interface IAppMsgContext : IAppMsgSink, IAppContext, IAppMsgReceiver
    {
        IAppMsgSink IAppMsgReceiver.Sink => this;
        
        void IAppMsgSink.Deposit(IEnumerable<IAppMsg> msg)
            => Control.iter(msg,Deposit);        

        void IAppMsgSink.Notify(IAppMsg msg)
            => Deposit(msg);

        void IAppMsgSink.Notify(string msg, AppMsgKind? kind)
            => Deposit(AppMsg.NoCaller(msg, kind));

        void IAppMsgSink.Displayed(IAppMsg msg)
            => Deposit(msg.AsDisplayed());

        void IAppMsgSink.NotifyConsole(IAppMsg msg, AppMsgColor color)
        {
            if(msg.Kind == AppMsgKind.Error)
                term.print(msg);
            else
                term.print(msg,color);
            
            Displayed(msg);
        }

        void IAppMsgSink.NotifyConsole(IAppMsg msg)
        {
            if(msg.Kind == AppMsgKind.Error)
                term.print(msg);
            else
                term.print(msg, msg.Color);
            
            Displayed(msg);
        }

        void IAppMsgSink.NotifyConsole(object content, AppMsgColor color)
            => NotifyConsole(AppMsg.Colorize(content, color));
    }
}