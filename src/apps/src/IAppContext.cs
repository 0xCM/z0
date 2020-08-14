//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IAppContext : IAppMsgQueue, IPolyrandProvider, IApiSet, IAppMsgContext, IAppBase
    {        
        IAppMsgQueue MessageQueue {get;}
        
        Action<IAppMsg> MessageRelay 
            => (e => term.print(e));

        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        void IAppMsgSink.Notify(string msg, MessageKind? severity)
            => MessageQueue.Notify(msg, severity);

        IReadOnlyList<IAppMsg> IAppMsgQueue.Dequeue()
            => MessageQueue.Dequeue();

        IReadOnlyList<IAppMsg> IAppMsgQueue.Flush(Exception e)
            => MessageQueue.Flush(e);

        void IAppMsgQueue.Emit(FilePath dst) 
            => MessageQueue.Emit(dst);
    }
}