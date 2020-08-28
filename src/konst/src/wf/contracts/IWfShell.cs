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
    using WfEvB = WfEventBuilder;

    public interface IWfShell : IDisposable
    {
        IShellContext Shell {get;}

        WfConfig Config {get;}

        FolderPath AppDataRoot
            => Shell.AppPaths.AppDataRoot;

        IShellPaths AppPaths
            => Shell.AppPaths;

        FolderPath ArchiveRoot
            => FolderPath.Define(@"k:/z0/archives");

        FolderPath ToolOuputDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("output");

        FolderPath ToolProcessDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("processed");

        IMultiSink WfSink {get;}

        FolderPath IndexRoot {get;}

        FolderPath ResourceRoot {get;}

        CorrelationToken Ct {get;}

        FolderPath AsmTables
            => ResourceRoot + FolderName.Define("tables");

        FolderPath AsmTableCore
            => AsmTables + FolderName.Define("asm");

        WfEventId Raise<E>(in E e)
            where E : IWfEvent;

        void Error(Exception e, CorrelationToken? ct = null, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(WfEvB.error(e, ct ?? Ct, caller, file, line));

        void Error<T>(string worker, T body, CorrelationToken? ct = null)
            => Raise(WfEvB.error(worker, body, ct ?? Ct));

        void Error(string actor, Exception e, CorrelationToken? ct = null)
            => Raise(WfEvB.error(actor, e, ct ?? Ct));

        void Created(string actor)
            => Raise(WfEventBuilder.newWorker(Ct, actor));

        void Created(WfStepId id)
            => Raise(WfEvB.created(id, Ct));

        void Running(WfStepId step, [File] string actor = null)
            => Raise(WfEvB.running(Path.GetFileNameWithoutExtension(actor), step, Ct));

        void Running<S,T>(WfStepId step, WfDataFlow<S,T> df)
            => Raise(WfEvB.running(step, df, Ct));

        void Ran<S,T,R>(WfStepId step, WfDataFlow<S,T,R> df)
            => Raise(WfEvB.ran(step, df, Ct));

        void Ran(WfStepId step, CorrelationToken ct)
            => Raise(new WfStepRan(step, ct));

        void Ran(WfStepId step)
            => Raise(new WfStepRan(step, Ct));

        void Ran<T>(WfStepId step, T data)
            => Raise(new WfStepRan<T>(step, data, Ct));

        void Status<T>(WfStepId step, T data)
            => Raise(new WfStatus<T>(step, data, Ct));

        void Created(in WfActor actor, CorrelationToken? ct = null)
            => Raise(WfEvB.created(ct ?? Ct, actor));

        void Created(in WfStepId step)
            => Raise(WfEvB.created(step, Ct));

        void Emitting(WfStepId step, string dataset, FilePath dst)
            => Raise(new WfEmitting(step, dataset, dst, Ct));

        void Emitted(WfStepId step, string dataset, uint count, FilePath dst)
            => Raise(new WfEmitted(step, dataset, count, dst, Ct));

        void Running<T>(WfStepId step, T content)
            => Raise(WfEvB.running(step, content, Ct));

        void Running(string actor)
        {
            Raise(new WfStepRunning(actor, WfStepId.Empty, Ct));
        }

        void Running(in WfActor actor, WfStepId step, CorrelationToken ct)
        {
            Raise(new WfStepRunning(actor, step, ct));
        }

        void Finished(string actor, CorrelationToken ct)
        {
            Raise(new WfFinished(actor, ct));
        }

        void Finished(WfStepId step, CorrelationToken ct)
            => Raise(new WfFinished(step.Format(), ct));

        void Finished(WfStepId step)
            => Raise(new WfFinished(step.Format(), Ct));

        void Initializing(string worker, CorrelationToken ct)
        {
            Raise(new WfInitializing(worker, ct));
        }

        void Initialized(string worker, CorrelationToken ct)
        {
            Raise(new WfInitialized(worker, ct));
        }

        void Created(string actor, CorrelationToken ct)
        {
            Raise(WfEvB.newWorker(ct, actor));
        }

        void Created(WfStepId step, CorrelationToken ct)
        {
            Raise(new WfStepCreated(step, ct));
        }

        void Emitting(string worker, string dataset, FilePath dst, CorrelationToken ct)
            => Raise(new WfEmitting(WfStepId.Empty, dataset, dst, ct));

        void Emitted(string actor, string dataset, uint count, FilePath dst, CorrelationToken ct)
            => Raise(new WfEmitted(WfStepId.Empty, dataset, count,  dst, ct));

        void Running(string actor, string message, CorrelationToken ct)
        {
            Raise(new WfStepRunning<string>(WfStepId.Empty, message, ct));
        }

        void Running(string actor, CorrelationToken ct)
        {
            Raise(new WfStepRunning(actor, WfStepId.Empty, ct));
        }

        void Status(string worker, string msg, CorrelationToken ct)
        {
            Raise(new WfStatus(worker, msg, ct));
        }

        void Finished(string actor)
        {
            Raise(new WfFinished(actor, Ct));
        }

        void Finished(in WfActor actor, CorrelationToken ct)
            => Raise(new WfActorFinished(actor, ct));

        void Initializing(string actor)
            => Raise(new WfInitializing(actor, Ct));

        void Initialized(string actor)
            => Raise(new WfInitialized(actor, Ct));

        void Running<T>(T message, string actor)
            => Raise(new WfStepRunning<T>(WfStepId.Empty, message, Ct));

        void Ran(in WfActor actor, WfStepId step, CorrelationToken ct)
            => Raise(new WfStepRan(actor, step, ct));

        void Ran(string actor)
            => Raise(new WfStepRan(actor, Ct));
    }
}