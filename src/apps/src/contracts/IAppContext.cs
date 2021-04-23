//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a context that carries and provides access to a composition
    /// </summary>
    public interface IAppContext : IAppMsgQueue, IPolyrandProvider, IAppMsgContext, IWfContext
    {
        IAppMsgQueue MessageQueue {get;}

        WfController IWfContext.Controller
            => root.controller();

        string[] IWfContext.Args
            => Environment.GetCommandLineArgs();

        Action<IAppMsg> MessageRelay
            => (e => term.print(e));

        IApiRuntimeCatalog RuntimeCatalog {get;}

        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        void IAppMsgSink.Notify(string msg, LogLevel? severity)
            => MessageQueue.Notify(msg, severity);

        IReadOnlyList<IAppMsg> IAppMsgQueue.Dequeue()
            => MessageQueue.Dequeue();

        IReadOnlyList<IAppMsg> IAppMsgQueue.Flush(Exception e)
            => MessageQueue.Flush(e);

        void IAppMsgQueue.Emit(FS.FilePath dst)
            => MessageQueue.Emit(dst);
    }
}