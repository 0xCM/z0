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

        void Notify(string msg, MessageKind? kind = null)
            => Deposit(AppMsg.define(msg, kind ?? MessageKind.Info));

        void NotifyConsole(IAppMsg msg)
        {
            if(msg.Kind == MessageKind.Error)
                term.print(msg);
            else
                term.print(msg, msg.Flair);

            Deposit(msg);
        }
    }
}