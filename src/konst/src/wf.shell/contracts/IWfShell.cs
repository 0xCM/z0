//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;
    using static WfShellUtility;
    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IWfShell : IDisposable, ITextual
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

        WfExecFlow Running()
        {
            SignalRunning();
            return Flow();
        }

        string ITextual.Format()
            => AppName;

        IWfShell WithHost(WfHost host)
            => clone(this, host, PolyStream, Verbosity);

        IWfShell WithRandom(IPolyStream random)
            => clone(this, Host, random, Verbosity);

        IWfShell WithVerbosity(LogLevel level)
            => clone(this, Host, PolyStream, level);

        void SignalTableEmitting(Type type, FS.FilePath dst)
            => Raise(tableEmitting(Host, type, dst, Ct));

        void SignalTableEmitting<T>(FS.FilePath dst)
            => Raise(tableEmitting<T>(Host, dst, Ct));

        WfExecFlow EmittingTable(Type type, FS.FilePath dst)
        {
            SignalTableEmitting(type, dst);
            return Flow();
        }

        WfExecFlow EmittingTable<T>(FS.FilePath dst)
            where T : struct
        {
            SignalTableEmitting<T>(dst);
            return Flow();
        }

        void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst)
            where T : struct
                => Raise(tableOut<T>(step, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst, WfExecFlow flow)
            where T : struct
                => Raise(tableOut<T>(Host, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
                => Raise(tableOut<T>(Host, count, dst, Ct));

        void EmittedTable(Type type, Count count, FS.FilePath dst)
            => Raise(tableOut(Host, type, count, dst, Ct));


        void Ran()
            => SignalRan();

        WfExecFlow Running<T>(T content)
        {
            SignalRunning(content);
            return Flow();
        }

        WfExecFlow Flow()
            => new WfExecFlow(this, NextExecToken());

        void SignalRunning()
            => Raise(running(Host, Ct));

        void SignalRunning<T>(T src)
            => Raise(running(Host, src, Ct));

        void SignalRan()
            => Raise(new RanEvent(Host, Ct));

        void SignalRan<T>(T content)
            => Raise(ran(Host, content, Ct));

        ICmdCatalog CmdCatalog
            => new CmdCatalog(this);

        Assembly[] Components
            => Context.ApiParts.Components;

        /// <summary>
        /// Returns a part-identified component, if found
        /// </summary>
        /// <param name="part">The part identifier</param>
        Option<Assembly> Component(PartId part)
        {
            var filtered = Components.Where(c => c.Id() == part);
            return filtered.Length > 0 ? some(filtered[0]) : none<Assembly>();
        }


        FolderPath ResourceRoot
            => FolderPath.Define(Init.ResDir.Name);

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

        // ~ Levels
        // ~ ---------------------------------------------------------------------------

        void Status<T>(WfStepId step, T data)
            => Raise(status(step, data, Ct));

        void Status<T>(T data)
            => Status(Host, data);

        void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        void Warn<T>(T content)
            => Warn(Host,content);

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(error(Host, e,  Ct, caller, file, line));

        void Error<T>(WfStepId step, T body)
            => Raise(error(step, body, Ct));

        void Error(WfStepId step, Exception e)
            => Raise(error(step, e, Ct));

        void Error(Exception e)
            => Error(Host, e);

        void Error<T>(T body)
            => Error(Host, body);

        void Error<H>(H host, Exception e)
            where H : WfHost<H>, new()
                => Raise(error(host.Id, e, Ct));

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

        void Created(WfStepId id)
        {
            if(Verbosity.Babble())
                Raise(created(id, Ct));
        }

        void Created()
            => Created(Host);

        void Created<H>(H host)
            where H : IWfHost<H>, new()
        {
            if(Verbosity.Babble())
                Raise(created(host.Id, Ct));
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

        void Disposed<T>(WfStepId step, T payload)
        {
            if(Verbosity.Babble())
                Raise(disposed(step, payload, Ct));
        }

        void Disposed<H>(H host)
            where H : WfHost<H>, new()
        {
            if(Verbosity == LogLevel.Babble)
                Raise(disposed(host.Id, Ct));
        }

        // ~ Running
        // ~ ---------------------------------------------------------------------------

        void Running(WfStepId step)
        {
            if(Verbosity.Babble())
                Raise(running(step, Ct));
        }

        void Running(WfHost host)
        {
            if(Verbosity.Babble())
                Raise(running(host, Ct));
        }

        void Running<T>(WfHost step, T content)
        {
            if(Verbosity.Babble())
                Raise(running(step, content, Ct));
        }

        void Running<T>(WfStepId step, T content)
        {
            if(Verbosity.Babble())
                Raise(running(step, content, Ct));
        }

        void ProcessingFile<T>(FS.FilePath src, T kind)
        {
            if(Verbosity.Babble())
                Raise(new ProcessingFileEvent<T>(Host, kind, src, Ct));
        }

        void EmittingFile<T>(T source, FS.FilePath dst)
            => Raise(fileEmitting<T>(Host, source, dst, Ct));


        void Running(CmdId cmd)
            => Raise(new RunningCmdEvent(cmd, Ct));

        void Succeeded<T>(CmdSpec cmd, T payload)
            => Raise(succeeded(cmd, payload, Ct));

        void Succeeded<T>(CmdSpec cmd)
            => Raise(succeeded(cmd, Ct));

        void Ran(CmdResult cmd)
            => Raise(new RanCmdEvent(cmd, Ct));

        void Ran(WfStepId step)
            => Raise(ran(step, Ct));

        void Ran2<T>(T content)
            => Raise(ran(Host, content, Ct));

        void Ran2<T>(WfExecFlow flow, T content)
        {
            Raise(ran(Host, content, Ct));
            Ran(flow);
        }

        void Ran<H,T>(H host, T content)
            where H : IWfHost<H>, new()
                => Raise(ran(host, content, Ct));

        void Emitted(WfStepId step, FS.FilePath dst, Count? segments = default)
            => Raise(fileOut(step, dst, segments ?? 0, Ct));

        void EmittedFile<T>(T source, Count count, FS.FilePath dst)
            => Raise(fileOut(Host, source, count, dst, Ct));

        void EmittedFile(Count count, FS.FilePath dst)
            => Raise(fileOut(Host, dst, count, Ct));


        void Processed<T>(T content)
            => processed(Host, content, Ct);

        void Processed<T>(ApiHostUri uri, T content)
            => processed(Host, Seq.delimit(uri,content), Ct);

        void Processed<S,T>(S src, T dst)
            => processed(Host, (src, dst), Ct);

        void ProcessedFile<T>(FS.FilePath src, T kind)
            => Raise(fileProcessed(Host, src, kind, Ct));

        void ProcessedFile<T,M>(FS.FilePath src, T kind, M metric)
            => Raise(fileProcessed(Host, src, kind, metric, Ct));

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

        void Row<K,T>(K kind, T content)
            where T : ITextual
            where K : unmanaged
                => Raise(rows(kind, content));
    }
}