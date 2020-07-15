//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IAppContext : TAppEnv, IAppMsgQueue, IPolyrandProvider, IApiSet, IAppMsgContext
    {        
        IAppMsgQueue MessageQueue {get;}
                
        S Service<S>()                
            => default;
        
        S LoadSettings<S>(FileName name)
            => default;
        Action<IAppMsg> MessageRelay 
            => (e => {});

        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        void IAppMsgSink.Notify(string msg, AppMsgKind? severity)
            => MessageQueue.Notify(msg, severity);

        IReadOnlyList<IAppMsg> IAppMsgQueue.Dequeue()
            => MessageQueue.Dequeue();

        IReadOnlyList<IAppMsg> IAppMsgQueue.Flush(Exception e)
            => MessageQueue.Flush(e);

        void IAppMsgQueue.Emit(FilePath dst) 
            => MessageQueue.Emit(dst);
    }
}