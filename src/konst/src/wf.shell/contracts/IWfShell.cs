//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;

    using static z;
    using static WfEvents;

    public partial interface IWfShell : IDisposable, ITextual
    {
        IWfAppPaths Paths {get;}

        IJsonSettings Settings {get;}

        IApiParts ApiParts {get;}

        CorrelationToken Ct {get;}

        string[] Args {get;}

        string AppName {get;}

        WfController Controller {get;}

        ISystemApiCatalog Api {get;}

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

        string ITextual.Format()
            => AppName;

        WfExecFlow Flow()
            => new WfExecFlow(this, NextExecToken());

        CmdBuilder CmdBuilder()
            => new CmdBuilder(this);

        Task<CmdResult> Dispatch(ICmdSpec cmd)
            => Task.Factory.StartNew(() => Router.Dispatch(cmd));

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

        FS.FolderPath DbRoot
            => Init.DbRoot;

        /// <summary>
        /// Provides a <see cref='IWfDb'/> rooted at a shell-configured location
        /// </summary>
        IWfDb Db()
            => new WfDb(this);

        WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            WfSink.Deposit(e);
            return e.EventId;
        }

        void Status<T>(WfStepId step, T data)
            => Raise(status(step, data, Ct));

        void Status<T>(T data)
            => Status(Host, data);

        void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        void Warn<T>(T content)
            => Warn(Host,content);

        void Error<T>(WfStepId step, T body)
            => Raise(error(step, body, Ct));

        void Error(WfStepId step, Exception e)
            => Raise(error(step, e, Ct));

        void Error(Exception e)
            => Error(Host, e);

        void Error<T>(T body)
            => Error(Host, body);

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
            if(Verbosity.Babble())
                Raise(disposed(step, Ct));
        }

        void Disposed(WfHost host)
        {
            if(Verbosity.Babble())
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