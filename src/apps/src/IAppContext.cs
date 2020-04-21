//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IAppContext : IAppEnv, IAppMsgQueue, IPolyrandProvider, IApiSet, IAppMsgContext
    {        
        IAppMsgQueue Messaging {get;}
        
        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => Messaging.Deposit(msg);

        void IAppMsgSink.Notify(string msg, AppMsgKind? severity)
            => Messaging.Notify(msg, severity);

        IReadOnlyList<IAppMsg> IAppMsgQueue.Dequeue()
            => Messaging.Dequeue();

        IReadOnlyList<IAppMsg> IAppMsgQueue.Flush(Exception e)
            => Messaging.Flush(e);

        void IAppMsgQueue.Emit(FilePath dst) 
            => Messaging.Emit(dst);
    }
}