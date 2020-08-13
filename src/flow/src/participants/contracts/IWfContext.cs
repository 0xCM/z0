//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;
    using static Flow;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Characterizes a worklow context
    /// </summary>
    public interface IWfContext : IDisposable
    {
        IAppContext ContextRoot {get;}
        
        WfConfig Config {get;}
        
        WfBroker Broker {get;}
                
        IMultiSink WfSink {get;}                
        
        FolderPath IndexRoot {get;}
        
        FolderPath ResourceRoot {get;}
                
        IPart[] Known {get;}
        
        IAppPaths AppPaths 
            => ContextRoot.AppPaths;

        CorrelationToken Ct {get;}
        
        WfEventId Raise<E>(in E e)
            where E : IWfEvent;        

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Flow.error(this, e, ct, caller, file, line);

        void Error<T>(string worker, T body, CorrelationToken ct)
            => Flow.error(worker, body, ct);
        
        void Error(string actor, Exception e, CorrelationToken ct)
            => Flow.error(this, actor, e, ct);

        void Error(in WfActor actor, Exception e, CorrelationToken ct)
            => Flow.error(this, actor, e, ct);

        void Warn<T>(string actor, T content, CorrelationToken ct)
            => Flow.warn(this, actor, content, ct);

        void Processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => Flow.processing(this, actor, kind, src, ct);

        void Processing<T>(T kind, FilePath src, [File] string actor = null, [Line] int? line = null)
            => Flow.processing(this, Path.GetFileNameWithoutExtension(actor), kind, src, Ct);

        void Processed<T>(T kind, FilePath src, uint size, [File] string actor = null, [Line] int? line = null)
            => Flow.processed(this,ToActorName(actor), kind, src, size, Ct);
        
        void Ran(string actor, CorrelationToken ct)
            => Flow.ran(this, actor, "Finished", ct);

        void Ran<T>(string actor, T data, CorrelationToken ct)
            => Flow.ran(this, actor, data, ct);
        
        void Status<T>(string worker, T data, CorrelationToken ct)
            => Flow.status(this, worker, data,ct);

        void Status<T>(in WfActor actor, T data, CorrelationToken ct)
            => Flow.status(this, actor, data, ct);

        void RunningT<T>(string actor, T data, CorrelationToken ct)
            => Flow.running(this, actor, data, ct);

        void RunningT<T>(in WfActor actor, T data, CorrelationToken ct)
            => Flow.running(this, actor, data, ct);

        void RanT<T>(string actor, T message, CorrelationToken ct)
            => Flow.ran(this, actor, message, ct);

        void Created(string actor)
            => Raise(Flow.wfWorkerCreated(Ct, actor));

        void Created(in WfActor actor, CorrelationToken ct)
            => Raise(Flow.created(ct, actor));

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
            Raise(Flow.wfWorkerCreated(ct, actor));            
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