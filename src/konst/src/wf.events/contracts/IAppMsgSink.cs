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
            => z.iter(msg, Deposit);

        void Notify(string msg, LogLevel? kind = null)
            => Deposit(AppMsg.define(msg, kind ?? LogLevel.Info));

        void NotifyConsole(IAppMsg msg)
        {
            // if(msg.Kind == LogLevel.Error)
            //     term.print(msg);
            // else
            //     term.print(msg, msg.Flair);

            Deposit(msg);
        }
    }
}