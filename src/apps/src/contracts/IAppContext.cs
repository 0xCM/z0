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
    public interface IAppContext : IMessageQueue, IPolyrandProvider, IWfContext
    {
        IMessageQueue MessageQueue {get;}

        WfController IWfContext.Controller
            => root.controller();

        string[] IWfContext.Args
            => Environment.GetCommandLineArgs();

        Action<IAppMsg> MessageRelay
            => (e => term.print(e));

        IApiRuntimeCatalog RuntimeCatalog {get;}

        void ISink<IAppMsg>.Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        void IMessageSink.Notify(string msg, LogLevel? severity)
            => MessageQueue.Notify(msg, severity);

        IReadOnlyList<IAppMsg> IMessageQueue.Dequeue()
            => MessageQueue.Dequeue();

        IReadOnlyList<IAppMsg> IMessageQueue.Flush(Exception e)
            => MessageQueue.Flush(e);

        void IMessageQueue.Emit(FS.FilePath dst)
            => MessageQueue.Emit(dst);
    }
}