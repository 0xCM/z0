//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static WfEvents;

    public interface IWfShell<C> : IShellContext<C>
    {
        IWfShell Shell {get;}
    }

    public interface IWfShell : IShellContext, IDisposable
    {
        SystemApiCatalog Api {get;}

        IShellContext Shell {get;}

        IWfEventSink WfSink {get;}

        ApiPartSet Modules {get;}

        IWfBroker Broker {get;}

        WfInit Init {get;}

        IPolyrand Random {get;}

        ApiContext ApiContext {get;}

        FS.FolderPath ArchiveRoot
            => FS.dir(@"k:\z0\archives");

        FS.FolderPath ToolOuputDir(string tool)
            => ArchiveRoot + FS.folder("tools") + FS.folder(tool) + FS.folder("output");

        FS.FolderPath ToolProcessDir(string tool)
            => ArchiveRoot + FS.folder("tools") + FS.folder(tool) + FS.folder("processed");

        FS.FolderPath AsmTables
            => Resources + FS.folder("tables");

        IPolySource PolySource
            => Random;

        IShellPaths IShellContext.Paths
            => Shell.Paths;

        FolderPath IndexRoot
            => FolderPath.Define(Init.IndexDir.Name);

        FolderPath ResourceRoot
            => FolderPath.Define(Init.ResDir.Name);

        FS.FolderPath Resources
            => FS.dir(ResourceRoot.Name);

        FS.FolderPath AppData
            => FS.dir(Shell.Paths.AppDataRoot.Name);

        IDbArchive Db()
            => new DbArchive(new ArchiveConfig(Paths.DbRoot));

        IWfShell WithSource(IPolyrand random);

        WfShell<S> WithState<S>(S src);

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

        void Status<T>(WfStepId step, T data)
            => Raise(WfEvents.status(step, data, Ct));

        void Status<C,R>(WfFunc<C,R> f, R result)
            where C : IWfStep<C>, new()
            where R : ITextual
                => Raise(new StatusEvent<C,R>(f, result, Ct));

        void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        void Error(Exception e, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(error(e, Ct, caller, file, line));

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(error(e,  Ct, caller, file, line));

        void Error(WfStepId step, Exception e, CorrelationToken? ct = null, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(error(e, ct ?? Ct, caller, file, line));

        void Error<T>(WfStepId step, T body)
            => Raise(error(step, body, Ct));

        void Error(WfStepId step, Exception e)
            => Raise(WfEvents.error(step, e, Ct));

        void Error<H>(H host, Exception e)
            where H : WfHost<H>, new()
                => Raise(WfEvents.error(host.Id, e, Ct));

        void Error<H>(H host, string msg, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            where H : WfHost<H>, new()
                => Raise(WfEvents.error(host.Id, msg, Ct, caller, file, line));

        // ~ Lifecycle
        // ~ ---------------------------------------------------------------------------

        void Created(ToolId tool)
            => Raise(created(tool, Ct));

        void Created(WfStepId id)
            => Raise(created(id, Ct));

        void Created<T>(WfStepId id, T content)
            => Raise(created(id, content, Ct));

        void Created<H>(H host)
            where H : IWfHost<H>, new()
                => Raise(created(host.Id, Ct));

        void Created<H>(H host, WfStepId step)
            where H : IWfHost<H>, new()
                => Raise(created(host.Id, step, Ct));

        void Disposed(WfStepId step)
            => Raise(disposed(step, Ct));

        void Disposed<T>(WfStepId step, T payload)
            => Raise(disposed(step, payload, Ct));

        void Disposed<H>(H host)
            where H : WfHost<H>, new()
                => Raise(disposed(host.Id, Ct));

        // ~ Running
        // ~ ---------------------------------------------------------------------------

        void Running(WfStepId step)
            => Raise(running(step, Ct));

        void Running<T>(WfStepId step, T content)
            => Raise(running(step, content, Ct));

        void Running<H,T>(H host, T content)
            where H : IWfHost<H>, new()
                => Raise(running(host, content, Ct));
        // ~ Ran
        // ~ ---------------------------------------------------------------------------

        void Ran(ToolId tool)
            => Raise(ran(tool, Ct));

        void Ran<T>(WfStepId step, T content)
            => Raise(new RanEvent<T>(step, content, Ct));

        void Ran(WfStepId step)
            => Raise(new RanEvent(step, Ct));

        void Ran<H,T>(H host, T content)
            where H : IWfHost<H>, new()
                => Raise(ran(host, content, Ct));

        void Emitted(WfStepId step, FS.FilePath dst, Count? segments = default)
            => Raise(emitted(step, dst, segments ?? 0, Ct));

        void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst, T t = default)
            where T : struct
                => Raise(new TableEmittedEvent<T>(step, count, dst, Ct));

        void EmittedTable(WfStepId step, Count count, FS.FilePath dst, Type t = default)
            => Raise(new TableEmittedEvent(step, t, count, dst, Ct));

        void Processed<T>(WfStepId step, DataFlow<T> flow)
            => Raise(processed(step, flow, Ct));

        void Processed<S,T>(WfStepId step, DataFlow<S,T> flow)
            => Raise(processed(step, flow, Ct));

        void Row<T>(T content)
            where T : ITextual
                => Raise(row(content, Ct));

        void Row<K,T>(K kind, T content)
            where T : ITextual
            where K : unmanaged
                => Raise(row(kind, content, Ct));
    }
}