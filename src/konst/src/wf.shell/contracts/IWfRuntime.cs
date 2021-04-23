//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;

    using static WfEvents;

    public partial interface IWfRuntime : IDisposable, ITextual
    {
        IAppPaths Paths {get;}

        IJsonSettings Settings {get;}

        IApiParts ApiParts {get;}

        CorrelationToken Ct {get;}

        string[] Args {get;}

        string AppName {get;}

        WfController Controller {get;}

        IApiRuntimeCatalog ApiCatalog {get;}

        IWfContext Context {get;}

        IWfEventSink EventSink {get;}

        IWfEventBroker EventBroker {get;}

        ICmdRouter Router {get;}

        IPolySource Polysource {get;}

        WfHost Host {get;}

        LogLevel Verbosity {get;}

        WfExecToken NextExecToken();

        WfServices Services {get;}

        IWfRuntime WithSource(IPolySource source);

        Env Env {get;}

        string ITextual.Format()
            => AppName;

        WfExecFlow<T> Flow<T>(T data)
            => new WfExecFlow<T>(this, data, NextExecToken());

        WfTableFlow<T> TableFlow<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
                => new WfTableFlow<T>(this, dst, NextExecToken());

        WfFileFlow Flow(FS.FilePath dst)
                => new WfFileFlow(this, dst, NextExecToken());

        WfCmdBuilder CmdBuilder()
            => new WfCmdBuilder(this);

        Task<CmdResult> Dispatch(ICmd cmd)
            => Task.Factory.StartNew(() => Router.Dispatch(cmd));

        CmdResult Execute(ICmd cmd)
            => Router.Dispatch(cmd);

        IWfRuntime WithHost(WfHost host)
            => this;

        Assembly[] Components
            => Context.ApiParts.Components;

        /// <summary>
        /// Provides a <see cref='IWfDb'/> rooted at a shell-configured location
        /// </summary>
        IWfDb Db()
            => new WfDb(this, Env.Db.Value);

        WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            EventSink.Deposit(e);
            return e.EventId;
        }

        void Status<T>(T data)
            => signal(this).Status(data);

        void Babble<T>(T data)
            => signal(this).Babble(data);

        void Warn<T>(T content)
            => signal(this).Warn(content);
    }
}