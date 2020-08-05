//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface IAppMsgSink : ISink<IAppMsg>, IAppBase
    {
        void Deposit(IEnumerable<IAppMsg> msg)
            => z.iter(msg, Deposit);        

        void Notify(string msg, AppMsgKind? kind = null)
            => Deposit(AppMsg.NoCaller(msg, kind));

        void NotifyConsole(IAppMsg msg)
        {
            if(msg.Kind == AppMsgKind.Error)
                term.print(msg);
            else
                term.print(msg, msg.Color);
            
            Deposit(msg);
        }
    }
}