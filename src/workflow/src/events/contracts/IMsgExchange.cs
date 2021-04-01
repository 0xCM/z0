//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public interface IMsgExchange : IAppMsgQueue
    {
        void IAppMsgSink.Deposit(IEnumerable<IAppMsg> msg)
        {}

        void IAppMsgSink.Notify(string msg, LogLevel? kind)
        {}

        void IAppMsgSink.NotifyConsole(IAppMsg msg)
        {
        }

        void ISink<IAppMsg>.Deposit(IAppMsg src)
        {}

        IReadOnlyList<IAppMsg> IAppMsgQueue.Dequeue()
            => sys.empty<IAppMsg>();

        void IAppMsgQueue.Emit(FS.FilePath dst)
        {}

        IReadOnlyList<IAppMsg> IAppMsgQueue.Flush(Exception e)
            => sys.empty<IAppMsg>();

        void IAppMsgQueueFlush(Exception e, IAppMsgSink target)
        {}
    }
}