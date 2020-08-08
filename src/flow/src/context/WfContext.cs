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
    using static Flow;
    using static z;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public struct WfContext : IWfContext<WfSettings>
    {        
        public const string ActorName = nameof(WfContext);
        
        public IAppContext ContextRoot {get;}
        
        public WfSettings State {get;}

        public WfTermEventSink TermSink {get;}
        
        public IMultiSink WfSink 
            => TermSink;
        
        public WfBroker Broker {get;}
                
        public FolderPath IndexRoot {get;}
        
        public FolderPath ResourceRoot {get;}
        
        public FilePath LogPath {get;}

        public CorrelationToken Ct {get;}

        long CtProvider;

        readonly ulong SessionId;

        [MethodImpl(Inline)]
        public WfContext(IAppContext root, CorrelationToken ct, WfSettings config, WfTermEventSink sink)
        {
            Ct = ct;
            ContextRoot = root;
            State = config;
            TermSink = sink;
            SessionId = (ulong)now().Ticks;
            CtProvider = 1;       
            ResourceRoot = ContextRoot.AppPaths.ResourceRoot;
            IndexRoot =  ResourceRoot + FolderName.Define("index");
            LogPath = root.AppPaths.AppDataRoot + FileName.Define("workflow", FileExtensions.Csv);
            Broker = new WfBroker(Ct);
            TermSink.Deposit(new OpeningWfContext(ActorName, typeof(WfContext), Ct));
        }

        public void Dispose()
        {
            TermSink.Deposit(new ClosingWfContext(ActorName, typeof(WfContext), Ct));
            TermSink.Dispose();
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
            TermSink.Deposit(@event);
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

        public void Processing<T>(T kind, FilePath src, [File] string actor = null, [Line] int? line = null)
            => Flow.processing(this, Path.GetFileNameWithoutExtension(actor), kind, src, Ct);

        public void Processed<T>(T kind, FilePath src, uint size, [File] string actor = null, [Line] int? line = null)
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