//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;

    using static memory;
    using static WfEvents;

    public partial interface IWfShell : IDisposable, ITextual
    {
        IAppPaths Paths {get;}

        IJsonSettings Settings {get;}

        IApiParts ApiParts {get;}

        CorrelationToken Ct {get;}

        string[] Args {get;}

        string AppName {get;}

        WfController Controller {get;}

        IGlobalApiCatalog Api {get;}

        IWfContext Context {get;}

        IWfEventSink WfSink {get;}

        IWfBroker Broker {get;}

        ICmdRouter Router {get;}

        IWfInit Init {get;}

        IPolyStream PolyStream {get;}

        WfHost Host {get;}

        LogLevel Verbosity {get;}

        WfExecToken NextExecToken();

        WfExecToken CloseExecToken(WfExecToken src);

        WfExecToken Ran(WfExecFlow src);

        WfExecToken Ran<T>(WfExecFlow<T> src);

        WfServices Services {get;}

        Env Env {get;}

        string ITextual.Format()
            => AppName;

        WfExecFlow Flow()
            => new WfExecFlow(this, NextExecToken());

        WfExecFlow<T> Flow<T>(string operation, T data)
            => new WfExecFlow<T>(this, operation, data, NextExecToken());

        WfTableFlow<T> TableFlow<T>(FS.FilePath dst)
            where T : struct, IRecord<T>
                => new WfTableFlow<T>(this, dst, NextExecToken());

        CmdBuilder CmdBuilder()
            => new CmdBuilder(this);

        Task<CmdResult> Dispatch(ICmd cmd)
            => Task.Factory.StartNew(() => Router.Dispatch(cmd));

        CmdResult Execute(ICmd cmd)
            => Router.Dispatch(cmd);

        IWfShell WithHost(WfHost host)
            => WfShell.clone(this, host, PolyStream, Verbosity);

        IWfShell WithRandom(IPolyStream random)
            => WfShell.clone(this, Host, random, Verbosity);

        IWfShell WithVerbosity(LogLevel level)
            => WfShell.clone(this, Host, PolyStream, level);

        Assembly[] Components
            => Context.ApiParts.PartComponents;

        FS.FolderPath ResourceRoot
            => FS.dir(Init.ResDir.Name);

        FS.FolderPath AppData
            => FS.dir(Context.Paths.AppDataRoot.Name);

        /// <summary>
        /// Provides a <see cref='IWfDb'/> rooted at a shell-configured location
        /// </summary>
        IWfDb Db()
            => WfDb.create(this);

        WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            WfSink.Deposit(e);
            return e.EventId;
        }

        void Status<T>(WfStepId step, T data)
            => signal(this).Status(step, data);

        void Status<T>(T data)
            => signal(this).Status(data);

        void Babble<T>(T data)
            => signal(this).Babble(data);

        void Babble<T>(WfStepId step, T data)
            => signal(this).Babble(step, data);

        void Warn<T>(WfStepId step, T data)
        {
            signal(this).Warn(step, data);
        }

        void Warn<T>(T content)
        {
            signal(this).Warn(content);
        }

        IWfService Service(Type host)
        {
            var service = (IWfService)Activator.CreateInstance(host);
            service.Init(this);
            return service;
        }

        H Service<H>()
            where H : IWfService<H>, new()
        {
            var svc = new H();
            svc.Init(this);
            return svc;
        }

        void Disposed(WfStepId step)
        {
            if(Verbosity.IsBabble())
                Raise(disposed(step, Ct));
        }

        void Disposed(WfHost host)
        {
            if(Verbosity.IsBabble())
                Raise(disposed(host.Id, Ct));
        }

        void Disposed()
            => Disposed(Host);

        void Row<T>(T data)
            => Raise(row(data));

        void Rows<T>(params T[] src)
            => Rows(@readonly(src));

        void Rows<T>(ReadOnlySpan<T> src)
        {
            if(src.Length != 0)
            {
                var buffer = Buffers.text();
                buffer.AppendLine("Rows");
                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    ref readonly var row = ref skip(src,i);
                    buffer.AppendLine(row is ITextual t ? t.Format() : row.ToString());
                }
                Raise(status(Host, buffer.Emit(), Ct));
            }
        }
    }
}