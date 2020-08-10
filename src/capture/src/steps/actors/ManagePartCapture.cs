//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static ManagePartCaptureStep;
    using static z;

    public struct ManagePartCapture : IDisposable
    {
        public static ManagePartCapture create(WfState state,  CorrelationToken ct)
            => new ManagePartCapture(state, ct);

        readonly WfState State;

        readonly IWfContext Wf;

        public WfConfig Config;

        readonly CorrelationToken Ct;

        readonly ICaptureContext Context;        
                
        readonly IPartCatalog[] Catalogs;        
        
        readonly IApiHost[] Hosts;

        [MethodImpl(Inline)]
        internal ManagePartCapture(WfState state, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Config = State.Config;
            Ct = ct;
            Context = State.CWf.Context;
            Catalogs = Context.ApiSet.MatchingCatalogs(state.Config.Parts).Array();
            var a = Catalogs.SelectMany(c => c.DataTypeHosts).Cast<IApiHost>();
            var b = Catalogs.SelectMany(c => c.OperationHosts).Cast<IApiHost>();            
            Hosts = a.Concat(b).OrderBy(x => x.PartId).ThenBy(x => (long)x.HostType.TypeHandle.Value).Array();
        }

        public void Run()
        {
            Clear(Config);  
            Capture(Archives.Services.CaptureArchive(Config.Target.ArchiveRoot));
        }

        public void Dispose()
        {
            Wf.Finished();
        }
 
        void Capture(IPartCaptureArchive dst)
        {
            var count = Catalogs.Length;
            for(var i=0; i<count; i++)
            {
                CapturePart(Catalogs[i], dst);
            }
        }

        public void Consolidate()
        {
            Wf.Raise(new RunningConsolidated(WorkerName, (uint)Catalogs.Length, Ct));
            
            Clear(Config);

            try
            {
                var dst = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot); 
                using var step = new CaptureHosts(State, Hosts, dst, Ct);
                step.Run();

            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
           }
        }
                
        void CapturePart(IPartCatalog src, IPartCaptureArchive dst)
        {
            if(src.IsNonEmpty)
            {
                Context.Raise(new CapturingPart(src.PartId));
                CaptureHosts(src,dst);
                Context.Raise(new CapturedPart(src.PartId));
            }
        }

        void CaptureHosts(IPartCatalog src, IPartCaptureArchive dst)
        {
            var hosts = span(src.OperationHosts);
            var count = hosts.Length;            
            using var step = new CaptureHostMembers(State, dst, Ct);   
            for(var i=0; i<count; i++)          
            {
                ref readonly var host = ref skip(hosts,i);                
                Context.Raise(new CapturingHost(host.Uri, Ct));
                step.Execute(host);
                Context.Raise(new CapturedHost(host.Uri, Ct));                
            } 
        }

        void Clear(WfConfig config) 
        {
            try
            {
                using var step = new ClearCaptureArchives(Wf, config, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
            }
        }
    }
}