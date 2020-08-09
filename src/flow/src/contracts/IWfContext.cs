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
        
        WfBroker Broker {get;}
                
        IMultiSink WfSink {get;}                
        
        FolderPath IndexRoot {get;}
        
        FolderPath ResourceRoot {get;}
        
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

        void Ran<T>(string actor, T body, CorrelationToken ct)
            => Flow.ran(this, actor, body, ct);
        
        void Status<T>(string worker, T body, CorrelationToken ct)
            => Flow.status(this, worker,body,ct);

        void RunningT<T>(string actor, T body, CorrelationToken ct)
            => Flow.running(this, actor, body, ct);
        
        void RanT<T>(string actor, T body, CorrelationToken ct)
            => Flow.ran(this, actor, body, ct);

        void Created([File] string src = null)
        {   
            Raise(Flow.created(Ct, src));
        }

        void Created(WfStepId step)
        {   
            Raise(new WfStepCreated(step, Ct));            
        }

        void Initializing([Caller] string worker = null)
        {
            Raise(new WorkerInitializing(worker, Ct));
        }

        void Initialized([Caller] string worker = null)
        {
            Raise(new WorkerInitialized(worker, Ct));
        }

        void Running<T>(T message, [File] string file = null)
        {
            Raise(new WfStepRunning<T>(ToActorName(file), message, Ct));
        }
        
        void Running([File] string file = null)
        {
            Raise(new WfStepRunning(ToActorName(file), Ct));
        }

        void Ran([File] string worker = null)
        {
            Raise(new WfStepRan(ToActorName(worker), Ct));
        }

        void Ran(WfStepId step)
        {
            Raise(new WfStepRan(step, Ct));
        }

        void Finished([Caller] string file = null)
        {   
            Raise(new WorkerFinished(ToActorName(file), Ct));            
        }

        void Finished(WfStepId step)
        {   
            Raise(new WorkerFinished(step.Format(), Ct));            
        }

        void Emitting(string worker, string dsname, FilePath dst)
        {
            Raise(new EmittingDataset(worker, dsname, dst, Ct));
        }

        void Emitted(string actor, string dsname, uint count, FilePath dst)
        {
            Raise(new EmittedDataset(actor, dsname, count, dst, Ct));
        }

        void Emitting(string worker, string dsname, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittingDataset(worker, dsname, dst, ct));
        }

        void Emitted(string actor, string dsname, uint count, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittedDataset(actor, dsname, count,  dst, ct));
        }

        void Running(string actor, string message, CorrelationToken ct)
        {
            Raise(new WfStepRunning<string>(actor, message, ct));
        }
        
        void Running(string worker, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, ct));
        }

        void Status(string worker, string msg, CorrelationToken ct)
        {   
            Raise(new WfStatus(worker, msg, ct));            
        }

        void Created(string worker, CorrelationToken ct)
        {   
            Raise(Flow.created(ct, worker));            
        }

        void Created(WfStepId step, CorrelationToken ct)
        {   
            Raise(new WfStepCreated(step, ct));            
        }

        void Finished(string worker, CorrelationToken ct)
        {   
            Raise(new WorkerFinished(worker, ct));            
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