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
    using EvF = WfEventBuilder;

    /// <summary>
    /// Characterizes a worklow context
    /// </summary>
    public interface IWfContext : IDisposable
    {
        IAppContext ContextRoot {get;}

        WfConfig Config {get;}

        IWfBroker Broker {get;}

        IMultiSink WfSink {get;}

        FolderPath IndexRoot {get;}

        FolderPath ResourceRoot {get;}

        FolderPath AppDataRoot
            => ContextRoot.AppPaths.AppDataRoot;

        FolderPath ConfigRoot
            => ContextRoot.AppPaths.ConfigRoot;

        IShellPaths AppPaths
            => ContextRoot.AppPaths;

        FolderPath ArchiveRoot
            => FolderPath.Define(@"k:/z0/archives");

        FolderPath ToolOuputDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("output");

        FolderPath ToolProcessDir(string tool)
            => ArchiveRoot + FolderName.Define("tools") + FolderName.Define(tool) + FolderName.Define("processed");

        FilePath ResPack
            => FilePath.Define(@"J:\dev\projects\z0-logs\respack\.bin\lib\netcoreapp3.0\z0.respack.dll");

        CorrelationToken Ct {get;}

        WfEventId Raise<E>(in E e)
            where E : IWfEvent;

        void Error(Exception e, CorrelationToken? ct = null, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Raise(EvF.error(e, ct ?? Ct, caller, file, line));

        void Error<T>(string worker, T body, CorrelationToken? ct = null)
            => Raise(EvF.error(worker, body, ct ?? Ct));

        void Error(string actor, Exception e, CorrelationToken? ct = null)
            => Raise(EvF.error(actor, e, ct ?? Ct));

        void Error(in WfActor actor, Exception e, CorrelationToken? ct = null)
            => Flow.error(this, actor, e, ct ?? Ct);

        void Warn<T>(string actor, T content, CorrelationToken? ct = null)
            => Flow.warn(this, actor, content, ct ?? Ct);

        void Processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => Flow.processing(this, actor, kind, src, ct);

        void ProcessingFile<T>(T kind, FilePath src, [File] string actor = null, [Line] int? line = null)
            => Flow.processing(this, Path.GetFileNameWithoutExtension(actor), kind, src, Ct);

        void ProcessedFile<T>(T kind, FilePath src, uint size, [File] string actor = null, [Line] int? line = null)
            => Flow.processed(this,ToActorName(actor), kind, src, size, Ct);

        void Ran(string actor, CorrelationToken ct)
            => Flow.ran(this, actor, "Finished", ct);

        void Ran<T>(string actor, T output, CorrelationToken? ct = null)
            => Flow.ran(this, actor, output, ct ?? Ct);

        void Status<T>(string worker, T message, CorrelationToken ct)
            => Flow.status(this, worker, message,ct);

        void Status<T>(T data, [File] string actor = null)
            => Flow.status(this, Path.GetFileNameWithoutExtension(actor), data,Ct);

        void Status<T>(in WfActor actor, T message, CorrelationToken ct)
            => Flow.status(this, actor, message, ct);

        void RunningT<T>(string actor, T output, CorrelationToken? ct = null)
            => Flow.running(this, actor, output, ct  ?? Ct);

        void RunningT<T>(in WfActor actor, T output, CorrelationToken? ct = null)
            => Flow.running(this, actor, output, ct ?? Ct);

        void RanT<T>(string actor, T output, CorrelationToken? ct = null)
            => Flow.ran(this, actor, output, ct ?? Ct);

        void Created(string actor)
            => Raise(WfEventBuilder.newWorker(Ct, actor));

        void Created(WfStepId id)
            => Raise(Flow.created(id, Ct));

        void Running(WfStepId step, [File] string actor = null)
            => Raise(Flow.running(Path.GetFileNameWithoutExtension(actor), step, Ct));

        void Created<T>(IWfStep<T> step)
            where T: struct,  IWfStep<T>
                => Created(step.Id);

        void Running<T>(IWfStep<T> step)
            where T: struct,  IWfStep<T>
                => Running(step.Id);

        void Ran<T>(IWfStep<T> step)
            where T: struct,  IWfStep<T>
                => Ran(step.Id);

        void Finished<T>(IWfStep<T> step)
            where T: struct,  IWfStep<T>
                => Finished(step.Id);

        void Ran(WfStepId step, [File] string actor = null)
            => Raise(Flow.ran(Path.GetFileNameWithoutExtension(actor), step, Ct));

        void Created(in WfActor actor, CorrelationToken? ct = null)
            => Raise(Flow.created(ct ?? Ct, actor));

        void Created(in WfActor actor)
            => Raise(Flow.created(Ct, actor));

        void Created(in WfWorker worker)
            => Raise(Flow.created(Ct, worker));

        void Created(in WfActor actor, WfStepId step, CorrelationToken ct)
            => Raise(new WfStepCreated(step, ct));

        void Initializing(string actor)
            => Raise(new WorkerInitializing(actor, Ct));

        void Initialized(string actor)
            => Raise(new WorkerInitialized(actor, Ct));

        void Running<T>(T message, string actor)
        {
            Raise(new WfStepRunning<T>(actor, message, Ct));
        }

        void Running(string actor)
        {
            Raise(new WfStepRunning(actor, WfStepId.Empty, Ct));
        }

        void Running(in WfActor actor, WfStepId step, CorrelationToken ct)
        {
            Raise(new WfStepRunning(actor, step, ct));
        }

        void Ran(in WfActor actor, WfStepId step, CorrelationToken ct)
        {
            Raise(new WfStepRan(actor, step, ct));
        }

        void Ran(string actor)
        {
            Raise(new WfStepRan(actor, Ct));
        }

        void Ran(WfStepId step)
        {
            Raise(new WfStepRan(step, Ct));
        }

        void Ran(WfStepId step, CorrelationToken ct)
        {
            Raise(new WfStepRan(step, ct));
        }

        void Finished(string actor)
        {
            Raise(new WorkerFinished(actor, Ct));
        }

        void Finished(in WfActor actor)
        {
            Raise(new ActorFinished(actor, Ct));
        }

        void Finished(in WfActor actor, CorrelationToken ct)
        {
            Raise(new ActorFinished(actor, ct));
        }

        void Finished(WfStepId step)
        {
            Raise(new WorkerFinished(step.Format(), Ct));
        }

        void Emitting(string worker, string table, FilePath dst)
        {
            Raise(new EmittingDataset(worker, table, dst, Ct));
        }

        void Emitted(string actor, string table, uint count, FilePath dst)
        {
            Raise(new EmittedDataset(actor, table, count, dst, Ct));
        }

        void Emitting(string worker, string table, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittingDataset(worker, table, dst, ct));
        }

        void Emitted(string actor, string table, uint count, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittedDataset(actor, table, count,  dst, ct));
        }

        void Running(string actor, string message, CorrelationToken ct)
        {
            Raise(new WfStepRunning<string>(actor, message, ct));
        }

        void Running(string actor, CorrelationToken ct)
        {
            Raise(new WfStepRunning(actor, WfStepId.Empty, ct));
        }

        void Status(string worker, string msg, CorrelationToken ct)
        {
            Raise(new WfStatus(worker, msg, ct));
        }

        void Created(string actor, CorrelationToken ct)
        {
            Raise(EvF.newWorker(ct, actor));
        }

        void Created(WfStepId step, CorrelationToken ct)
        {
            Raise(new WfStepCreated(step, ct));
        }

        void Finished(string actor, CorrelationToken ct)
        {
            Raise(new WorkerFinished(actor, ct));
        }

        void Finished(WfStepId step, CorrelationToken ct)
        {
            Raise(new WorkerFinished(step.Format(), ct));
        }

        void Initializing(string worker, CorrelationToken ct)
        {
            Raise(new WorkerInitializing(worker, ct));
        }

        void Initialized(string worker, CorrelationToken ct)
        {
            Raise(new WorkerInitialized(worker, ct));
        }

        static string ToActorName(string src)
            => Path.GetFileNameWithoutExtension(src);
    }
}