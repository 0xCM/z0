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

    public interface IWfShell : IShellContext, IDisposable
    {
        ApiSet Api {get;}

        IShellContext Shell {get;}

        IWfEventSink WfSink {get;}

        FolderPath IndexRoot {get;}

        FolderPath ResourceRoot {get;}

        ApiModules Modules {get;}

        IWfBroker Broker {get;}

        WfInit Init {get;}

        FolderPath AppDataRoot
            => Shell.Paths.AppDataRoot;

        FolderPath ArchiveRoot
            => FolderPath.Define(@"k:/z0/archives");

        FolderPath ToolOuputDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("output");

        FolderPath ToolProcessDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("processed");

        FolderPath AsmTables
            => ResourceRoot + FolderName.Define("tables");

        WfEventId Raise<E>(in E e)
            where E : IWfEvent
        {
            WfSink.Deposit(e);
            return e.EventId;
        }

        void Raise<T>(DataRow<T>[] src)
            where T : ITextual
        {
            foreach(var row in src)
                Raise(row);
        }

        void Error(Exception e, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfEvents.error(e, Ct, caller, file, line));

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfEvents.error(e,  Ct, caller, file, line));

        void Error(WfStepId step, Exception e, CorrelationToken? ct = null, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(error(e, ct ?? Ct, caller, file, line));

        void Error<T>(WfStepId step, T body)
            => Raise(error(step, body, Ct));

        void Error(string actor, Exception e, CorrelationToken? ct = null)
            => Raise(error(actor, e, ct ?? Ct));

        void Created(WfToolId tool)
            => Raise(created(tool, Ct));

        void Created(WfStepId id)
            => Raise(created(id, Ct));

        void Warn<T>(WfStepId id, T content)
            => Raise(warn(id, content, Ct));

        void Created<T>(WfStepId id, T content)
            => Raise(WfEvents.created(id, content, Ct));

        void DataRow<T>(T content)
            where T : ITextual
                => Raise(WfEvents.data(typeof(T).Name, content, Ct));

        void DataRow<K,T>(K kind, T content)
            where T : ITextual
                => Raise(WfEvents.data(kind, content, Ct));

        void Running(WfStepId step, [File] string actor = null)
            => Raise(WfEvents.running(callerName(actor), step, Ct));

        void Running<T>(T step, [File] string caller = null)
            where T : struct, IWfStep<T>
                => Raise(WfEvents.running(step, callerName(caller), Ct));

        void Running<S,T>(S step, T content)
            where S : struct, IWfStep<S>
                => Raise(WfEvents.running(step,content, Ct));

        void Ran<S,T>(S step, T content)
            where S : struct, IWfStep<S>
                => Raise(ran(step,content, Ct));

        void Ran<T>(T step, [File] string caller = null)
            where T : struct, IWfStep<T>
                => Raise(ran(step, callerName(caller), Ct));

        void Running<S,T>(WfStepId step, WfDataFlow<S,T> df)
            => Raise(running(step, df, Ct));

        void Ran<S,T,R>(WfStepId step, WfDataFlow<S,T,R> df)
            => Raise(ran(step, df, Ct));

        void Ran(WfStepId step, CorrelationToken ct)
            => Raise(new WfStepRan(step, Ct));

        void Ran(WfStepId step)
            => Raise(new WfStepRan(step, Ct));

        void Ran<T>(WfStepId step, T data)
            => Raise(new WfStepRan<T>(step, data, Ct));

        void Status<T>(WfStepId step, T data)
            => Raise(new WfStatus<T>(step, data, Ct));

        void Status<C,R>(WfFunc<C,R> f, R result)
            where C : struct, IWfStep<C>
            where R : ITextual
                => Raise(new WfStatus<C,R>(f, result, Ct));

        void Created(in WfStepId step)
            => Raise(WfEvents.created(step, Ct));

        void Emitting(WfStepId step, Type table, FS.FilePath dst)
            => Raise(new EmittingTable(step, table, dst, Ct));

        void Emitting<T>(WfStepId step, FS.FilePath dst)
            where T : struct
                => Raise(new EmittingTable(step, typeof(T), dst, Ct));

        void Emitted<T>(WfStepId step, Count32 count, FS.FilePath dst)
            where T : struct
                => Raise(new EmittedTable(step, typeof(T), count, dst, Ct));

        void Emitting(WfStepId step, TableId table, FS.FilePath dst)
            => Raise(new EmittingTable(step, table, dst, Ct));

        void Emitted(WfStepId step, TableId table, uint count, FS.FilePath dst)
            => Raise(WfEvents.emitted(step, table, count, dst, Ct));

        void Running<T>(WfStepId step, T content)
            => Raise(WfEvents.running(step, content, Ct));

        void Disposed(WfStepId step)
            => Raise(WfEvents.disposed(step, Ct));

        void Initializing(WfStepId step, CorrelationToken ct)
            => Raise(new Initializing(step, Ct));

        void Initialized(WfStepId step, CorrelationToken ct)
            => Raise(new Initialized(step, Ct));

        void Created(WfStepId step, CorrelationToken ct)
            => Raise(new WfStepCreated(step, Ct));

        void Error(WfStepId step, Exception e)
            => Raise(WfEvents.error(step, e, Ct));

        static string callerName(string src)
            => Path.GetFileNameWithoutExtension(src);

        void Processed<T>(WfStepId step, WfDataFlow<T> flow)
            => Raise(WfEvents.processed(step, flow, Ct));

        void Processed<S,T>(WfStepId step, WfDataFlow<S,T> flow)
            => Raise(WfEvents.processed(step, flow, Ct));
    }
}