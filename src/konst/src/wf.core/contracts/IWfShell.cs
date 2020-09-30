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
        ApiParts Api {get;}

        IShellContext Shell {get;}

        IWfEventSink WfSink {get;}

        FolderPath IndexRoot {get;}

        FolderPath ResourceRoot {get;}

        ApiModules Modules {get;}

        IWfBroker Broker {get;}

        WfInit Init {get;}

        IPolyrand Random {get;}

        IPolySource PolySource
            => Random;

        FS.FolderPath Resources
            => FS.dir(ResourceRoot.Name);

        IWfShell WithSource(IPolyrand random);

        ApiContext ApiContext {get;}

        FolderPath AppDataRoot
            => Shell.Paths.AppDataRoot;

        WfShell<S> WithState<S>(S src);

        IFileDb FileDb()
            => new FileDb(FS.dir(Paths.LogRoot.Name) + FS.folder("db"));

        IFileDb FileDb(FS.FolderPath root)
            => new FileDb(root);

        FolderPath ArchiveRoot
            => FolderPath.Define(@"k:/z0/archives");

        FolderPath ToolOuputDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("output");

        FolderPath ToolProcessDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("processed");

        FS.FolderPath AsmTables
            => Resources + FS.folder("tables");

        WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            WfSink.Deposit(e);
            return e.EventId;
        }

        void Raise<T>(RowCreated<T>[] src)
            where T : ITextual
        {
            foreach(var row in src)
                Raise(row);
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
                => Raise(new WfStatus<C,R>(f, result, Ct));

        void Warn<T>(WfStepId step, T content)
            => Raise(warn(step, content, Ct));

        void Error(Exception e, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfEvents.error(e, Ct, caller, file, line));

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfEvents.error(e,  Ct, caller, file, line));

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

        void Created(WfStepId id)
            => Raise(created(id, Ct));

        void Created<T>(WfStepId id, T content)
            => Raise(WfEvents.created(id, content, Ct));

        void Created(WfStepId step, CorrelationToken ct)
            => Raise(new WfStepCreated(step, Ct));

        void Created(in WfStepId step)
            => Raise(WfEvents.created(step, Ct));

        void Disposed(WfStepId step)
            => Raise(WfEvents.disposed(step, Ct));

        void Disposed<T>(WfStepId step, T payload)
            => Raise(WfEvents.disposed(step, payload, Ct));

        void Created<H>(H host)
            where H : IWfHost<H>, new()
                => Raise(WfEvents.created(host.Id, Ct));

        void CreatedStep<H>(H host, Type step)
            where H : IWfHost<H>, new()
                => Raise(WfEvents.created(host.Id, step, Ct));

        void Disposed<H>(H host)
            where H : WfHost<H>, new()
                => Raise(WfEvents.disposed(host.Id, Ct));

        // ~ Initialization
        // ~ ---------------------------------------------------------------------------

        void Initializing(WfStepId step, CorrelationToken ct)
            => Raise(new Initializing(step, Ct));

        void Initialized(WfStepId step, CorrelationToken ct)
            => Raise(new Initialized(step, Ct));

        // ~ Running
        // ~ ---------------------------------------------------------------------------

        void Running(WfStepId step, string actor = "fixme")
            => Raise(running(callerName(actor), step, Ct));

        void Running<T>(WfStepId step, T content)
            => Raise(WfEvents.running(step, content, Ct));

        void Running<H,T>(H host, T content)
            where H :  IWfHost<H>, new()
                => Raise(running(host, content, Ct));

        void RunningStep<H>(H host, Type step)
            where H :  IWfHost<H>, new()
                => Raise(running(host, step, Ct));

        void Running<S,T>(WfStepId step, DataFlow<S,T> df)
            => Raise(running(step, df, Ct));

        // ~ Ran
        // ~ ---------------------------------------------------------------------------

        void Ran<T>(WfStepId step, T content)
            => Raise(new WfStepRan<T>(step, content, Ct));

        void Ran(WfStepId step)
            => Raise(new WfStepRan(step, Ct));

        void Ran<H,T>(H host, T content)
            where H : IWfHost<H>, new()
                => Raise(ran(host, content, Ct));

        void RanStep<H>(H host, Type step)
            where H : IWfHost<H>, new()
                => Raise(ran(host, step, Ct));

        void Ran<H,S,T,R>(H host, DataFlow<S,T,R> df)
            where H : IWfHost<H>, new()
                => Raise(flowed(host, df,Ct));

        // ~ Processing
        // ~ ---------------------------------------------------------------------------

        void Emitting(WfStepId step, Type table, FS.FilePath dst)
            => Raise(new EmittingTable(step, table, dst, Ct));

        void Emitting<T>(WfStepId step, FS.FilePath dst)
            where T : struct
                => Raise(new EmittingTable(step, typeof(T), dst, Ct));

        void Emitting<H,T>(H host, T t, FS.FilePath dst)
            where H : IWfHost<H>, new()
            where T : struct
                => Raise(new EmittingTable(host.Id, typeof(H), dst, Ct));

        void Emitted<T>(WfStepId step, Count count, FS.FilePath dst)
            where T : struct
                => Raise(new EmittedTable(step, typeof(T), count, dst, Ct));

        void Emitted<H,T>(H host, T t, Count count, FS.FilePath dst)
            where H : IWfHost<H>, new()
            where T : struct
                => Raise(new EmittedTable(host.Id, typeof(T), count, dst, Ct));

        void Emitting(WfStepId step, TableId table, FS.FilePath dst)
            => Raise(new EmittingTable(step, table, dst, Ct));

        void Emitted(WfStepId step, TableId table, uint count, FS.FilePath dst)
            => Raise(WfEvents.emitted(step, table, count, dst, Ct));

        void Processed<T>(WfStepId step, DataFlow<T> flow)
            => Raise(WfEvents.processed(step, flow, Ct));

        void Processed<S,T>(WfStepId step, DataFlow<S,T> flow)
            => Raise(WfEvents.processed(step, flow, Ct));

        void Row<T>(T content)
            where T : ITextual
                => Raise(WfEvents.row(content, Ct));

        void Row<K,T>(K kind, T content)
            where T : ITextual
            where K : unmanaged
                => Raise(row(kind, content, Ct));

        static string callerName(string src)
            => Path.GetFileNameWithoutExtension(src);

        // ~~ Tools

        void Created(ToolId tool)
            => Raise(created(tool, Ct));

        void Running(ToolId tool)
            => Raise(running(tool, Ct));

        void Ran(ToolId tool)
            => Raise(ran(tool, Ct));
    }
}