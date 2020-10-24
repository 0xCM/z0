//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static WfEvents;

    public interface IWfShell : IWfContext, IDisposable
    {
        ISystemApiCatalog Api {get;}

        IWfContext Shell {get;}

        IWfEventSink WfSink {get;}

        IWfBroker Broker {get;}

        IWfInit Init {get;}

        IPolyrand Random {get;}

        WfHost Host {get;}

        LogLevel Verbosity {get;}

        IWfShell WithSource(IPolyrand random);

        IWfShell WithHost(WfHost host);

        IWfShell WithVerbosity(LogLevel level);

        IPolySource PolySource
            => Random;

        IWfPaths IWfContext.Paths
            => Shell.Paths;

        FolderPath IndexRoot
            => FolderPath.Define(Init.IndexDir.Name);

        FolderPath ResourceRoot
            => FolderPath.Define(Init.ResDir.Name);

        FS.FolderPath Resources
            => FS.dir(ResourceRoot.Name);

        FS.FolderPath AppData
            => FS.dir(Shell.Paths.AppDataRoot.Name);

        IFileDb Db()
            => Z0.Db.files(this, new FileDbPaths(EnvRules.Default.DbRoot()));

        WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            WfSink.Deposit(e);
            return e.EventId;
        }

        // ~ Levels
        // ~ ---------------------------------------------------------------------------

        void Trace<T>(WfStepId step, T data)
            => Raise(WfEvents.trace(step, data, Ct));

        void Trace<T>(T data)
            => Trace(Host, data);

        void Status<T>(WfStepId step, T data)
            => Raise(WfEvents.status(step, data, Ct));

        void Status<T>(T data)
            => Status(Host,data);

        void Status<C,R>(WfFunc<C,R> f, R result)
            where C : IWfStep<C>, new()
            where R : ITextual
                => Raise(new StatusEvent<C,R>(f, result, Ct));

        void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        void Warn<T>(T content)
            => Warn(Host,content);

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfErrors.error(e,  Ct, caller, file, line));

        void Error(WfStepId step, Exception e, CorrelationToken? ct = null, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfErrors.error(e, ct ?? Ct, caller, file, line));

        void Error<T>(WfStepId step, T body)
            => Raise(WfErrors.error(step, body, Ct));

        void Error(WfStepId step, Exception e)
            => Raise(WfErrors.error(step, e, Ct));

        void Error(Exception e)
            => Error(Host, e);

        void Error<T>(T body)
            => Error(Host, body);

        void Error<H>(H host, Exception e)
            where H : WfHost<H>, new()
                => Raise(WfErrors.error(host.Id, e, Ct));

        // ~ Lifecycle
        // ~ ---------------------------------------------------------------------------

        void Created(ToolId tool)
            => Raise(created(tool, Ct));

        void Created(WfStepId id)
        {
            if(Verbosity.Babble())
                Raise(created(id, Ct));
        }

        void Created()
            => Created(Host);

        void Created<T>(WfStepId id, T content)
        {
            if(Verbosity.Babble())
                Raise(created(id, content, Ct));
        }

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

        ExecutionFlow Running();

        void Ran();

        void Running(CmdId cmd)
            => Raise(new RunningCmdEvent(cmd, Ct));

        void Ran(CmdResult cmd)
            => Raise(new RanCmdEvent(cmd, Ct));

        void Ran(ExecutionFlow flow);

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

        void Running<T>(T content)
        {
            if(Verbosity.Babble())
                Raise(running(Host, content, Ct));
        }

        // ~ Ran
        // ~ ---------------------------------------------------------------------------

        void Ran(ToolId tool)
            => Raise(ran(tool, Ct));

        void Ran<T>(WfStepId step, T content)
            => Raise(new RanEvent<T>(step, content, Ct));

        void Ran(WfStepId step)
        {
            if(Verbosity.Babble())
                Raise(new RanEvent(step, Ct));
        }

        void Ran2<T>(T content)
            => Raise(new RanEvent<T>(Host, content, Ct));

        void Ran<H,T>(H host, T content)
            where H : IWfHost<H>, new()
                => Raise(ran(host, content, Ct));

        void EmittingFile<T>(T source, FS.FilePath dst)
        {
            if(Verbosity.Babble())
                Raise(new EmittingFileEvent<T>(Host, source, dst, Ct));
        }

        void EmittingFile(Count measure, FS.FilePath dst)
            => Raise(new EmittingFileEvent<Count>(Host, measure, dst, Ct));

        void Emitted(WfStepId step, FS.FilePath dst, Count? segments = default)
            => Raise(emitted(step, dst, segments ?? 0, Ct));

        void Emitted(FS.FilePath dst, Count? segments = default)
            => Emitted(Host,dst,segments);

        void EmittedFile<T>(T source, Count count, FS.FilePath dst)
            => Raise(new EmittedFileEvent<T>(Host, source, count, dst, Ct));

        void EmittedFile(Count count, FS.FilePath dst)
            => Raise(new EmittedFileEvent(Host, dst, count, Ct));

        void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst, T t = default)
            where T : struct
                => Raise(new EmittedTableEvent<T>(step, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst, T t = default)
            where T : struct
                => EmittedTable<T>(Host,count,dst);

        void EmittedTable(WfStepId step, Type type, Count count, FS.FilePath dst)
            => Raise(new EmittedTableEvent(step, type, count, dst, Ct));

        void EmittingTable(Type type, FS.FilePath dst)
        {
            if(Verbosity.Babble())
                Raise(new EmittingTableEvent(Host, type, dst, Ct));
        }

        void EmittingTable<T>(FS.FilePath dst, T t = default)
            where T : struct
        {
            if(Verbosity.Babble())
                Raise(new EmittingTableEvent<T>(Host, dst, Ct));
        }

        void EmittedTable(Type type, Count count, FS.FilePath dst)
            => EmittedTable(Host, type, count, dst);

        void Processed<T>(T content)
            => WfEvents.processed(Host, content, Ct);

        void Processed<T>(ApiHostUri uri, T content)
            => WfEvents.processed(Host, delimit(uri,content), Ct);

        void Processed<S,T>(S src, T dst)
            => WfEvents.processed(Host, (src, dst), Ct);

        void ProcessingFile<T>(FS.FilePath src, T kind)
        {
            if(Verbosity.Babble())
                Raise(new ProcessingFileEvent<T>(Host, kind, src, Ct));
        }

        void ProcessedFile<T>(FS.FilePath src, T kind)
            => Raise(new ProcessedFileEvent<T>(Host, src, kind, Ct));

        void ProcessedFile<T,M>(FS.FilePath src, T kind, M metric)
            => Raise(new ProcessedFileEvent<T,M>(Host, src, kind, metric, Ct));

        void Row<T>(T content)
            where T : ITextual
                => Raise(rows(content));

        void Rows<T>(params T[] content)
            where T : ITextual
        {
            if(content.Length != 0)
            {
                var buffer = Buffers.text();
                buffer.AppendLine("Rows");
                var src = @readonly(content);
                for(var i=0; i<content.Length; i++)
                {
                    ref readonly var row = ref skip(src,i);
                    buffer.AppendLine(row.Format());
                }
                Raise(status(Host,buffer.Emit(), Ct));
            }
        }

        void Row<K,T>(K kind, T content)
            where T : ITextual
            where K : unmanaged
                => Raise(rows(kind, content));
    }
}