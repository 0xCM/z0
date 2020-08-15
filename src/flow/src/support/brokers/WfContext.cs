//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
        
    using static Konst;
    using static z;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public struct WfContext : IWfContext
    {                
        public IAppContext ContextRoot {get;}        

        public CorrelationToken Ct {get;}
        
        public WfConfig Config {get;}
        
        public IMultiSink WfSink {get;}
        
        public IWfBroker Broker {get;}
                
        public FolderPath IndexRoot {get;}
        
        public FolderPath ResourceRoot {get;}
        
        public IPart[] Known {get;}
        
        readonly WfActor Actor;

        [MethodImpl(Inline)]
        public WfContext(IAppContext root, CorrelationToken ct, WfConfig config, WfTermEventSink sink, [Caller] string caller = null)
        {
            Ct = ct;
            ContextRoot = root;
            Config = config;
            WfSink = sink;
            Actor = Flow.actor(caller);
            ResourceRoot = ContextRoot.AppPaths.ResourceRoot;
            IndexRoot =  ResourceRoot + FolderName.Define("index");
            Known = ContextRoot.Parts;            
            Broker = new WfBroker(Ct);
            ((WfBroker)Broker).WithContext(this);
            WfSink.Deposit(new WfContextLoaded(Actor, Ct));
        }

        public void Dispose()
        {
            WfSink.Deposit(new WfContextUnloaded(Actor, Ct));
            WfSink.Dispose();
            Broker.Dispose();
        }
                
        public IAppPaths AppPaths
        {
            [MethodImpl(Inline)]
            get => ContextRoot.AppPaths;
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            WfSink.Deposit(@event);
            return @event.EventId;
        }

        public void Error<T>(string actor, T body, CorrelationToken ct)
            => Flow.error(this, actor, body, ct);

        public void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Flow.error(this, e, ct, caller, file, line);
        
        public void Error(string actor, Exception e, CorrelationToken ct)
            => Flow.error(this, actor, e, ct);

        public void Warn<T>(string actor, T content, CorrelationToken ct)
            => Flow.warn(this, actor, content, ct);

        public void Processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => Flow.processing(this, actor, kind, src, ct);

        public void ProcessingFile<T>(T kind, FilePath src, [File] string actor = null, [Line] int? line = null)
            => Flow.processing(this, Path.GetFileNameWithoutExtension(actor), kind, src, Ct);

        public void ProcessedFile<T>(T kind, FilePath src, uint size, [File] string actor = null, [Line] int? line = null)
            => Flow.processed(this,ToActorName(actor), kind, src, size, Ct);
        
        public void Ran(string actor, CorrelationToken ct)
            => Flow.ran(this, actor, "Finished", ct);

        public void Ran<T>(string actor, T body, CorrelationToken ct)
            => Flow.ran(this, actor, body, ct);
        
        public void Status<T>(string worker, T body, CorrelationToken ct)
            => Flow.status(this, worker,body,ct);

        public void RunningT<T>(string actor, T body, CorrelationToken ct)
            => Flow.running(this, actor, body, ct);
        
        public void RanT<T>(string actor, T body, CorrelationToken ct)
            => Flow.ran(this, actor, body, ct);

        static string ToActorName(string src)
            => Path.GetFileNameWithoutExtension(src);
    }
}