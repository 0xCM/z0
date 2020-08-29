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

        readonly WfActor Actor;

        readonly IWfEventLog Log;

        [MethodImpl(Inline)]
        public WfContext(IAppContext root, CorrelationToken ct, WfConfig config, WfTermEventSink sink, [Caller] string caller = null)
        {
            Ct = ct;
            Config = config;
            ContextRoot = root;
            Log = AB.log(config);
            Broker = new WfBroker(Log, Ct);
            WfSink = sink;
            Actor = Flow.actor(caller);
            ResourceRoot = ContextRoot.AppPaths.ResourceRoot;
            IndexRoot =  ResourceRoot + FolderName.Define("index");
            ((WfBroker)Broker).WithContext(this);
            WfSink.Deposit(new WfContextLoaded(Actor, Ct));
        }

        public void Dispose()
        {
            WfSink.Deposit(new WfContextUnloaded(Actor, Ct));
            Broker.Dispose();
            Log.Dispose();
        }

        public IShellPaths AppPaths
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

        public void Processing<T>(T kind, FilePath src, [File] string actor = null, [Line] int? line = null)
            => Flow.processing(this, Path.GetFileNameWithoutExtension(actor), kind, src, Ct);

        public void Processed<T>(T kind, FilePath src, uint size, [File] string actor = null, [Line] int? line = null)
            => Flow.processed(this,ToActorName(actor), kind, src, size, Ct);

        public void Ran(string actor, CorrelationToken ct)
            => Flow.ran(this, actor, "Finished", ct);

        static string ToActorName(string src)
            => Path.GetFileNameWithoutExtension(src);
    }
}