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

    public class ManageCaptureStep : IManageCaptureStep
    {
        public static ManageCaptureStep create(ICaptureWorkflow wf, PartWfConfig config, CorrelationToken? ct = null)
            => new ManageCaptureStep(wf, config, ct);

        readonly CorrelationToken Ct;

        public CaptureState State;
        
        public ICaptureWorkflow CWf {get;}

        public PartWfConfig Config;

        readonly WfContext Wf;
        
        ICaptureContext Context 
            => CWf.Context;

        public void Status(string msg)
        {
            Wf.Status(msg, Ct);
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            Wf.Sink.Deposit(@event);
            return @event.Id;
        }

        [MethodImpl(Inline)]
        internal ManageCaptureStep(ICaptureWorkflow cwf, PartWfConfig config, CorrelationToken? ct)
        {
            State = new CaptureState(cwf, config, ct);
            Ct = ct ?? CorrelationToken.create();
            CWf = cwf;
            Wf = config.Context;
            Config = config;
        }
        
        void Clear(PartWfConfig config) 
        {
            try
            {
                using var step = new ClearCaptureArchives(config);
                step.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        IPartCatalog[] Catalogs(IApiSet src)
        {
            return src.Catalogs;
        }

        public void Run()
        {
            Clear(Config);  

            var dst = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot);    
            var catalogs = Catalogs(Context.ApiSet).Array();
            CaptureParts(catalogs, dst);
        }

        public void CaptureParts(PartWfConfig config)
        {
            Clear(config);  

            var dst = Archives.Services.CaptureArchive(config.Target.ArchiveRoot);    
            var catalogs = Catalogs(Context.ApiSet).Array();
            CaptureParts(catalogs, dst);
        }

        public void Consolidate()
        {
            var catalogs = Catalogs(Context.ApiSet).Array();
            Raise(new RunningConsolidated(catalogs.Length));
            
            Clear(Config);

            try
            {
                var a = catalogs.SelectMany(c => c.DataTypeHosts).Cast<IApiHost>();
                var b = catalogs.SelectMany(c => c.OperationHosts).Cast<IApiHost>();
                var hosts = a.Concat(b).OrderBy(x => x.PartId).ThenBy(x => (long)x.HostType.TypeHandle.Value).Array();

                Status($"Consolidated {hosts.Length} hosts");    
                
                var dst = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot); 
                using var step = CaptureHostStep.create(State);
                step.Capture(hosts, dst);

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
        
        public void CaptureParts(IPartCatalog[] src, TPartCaptureArchive dst)
        {
            for(var i=0; i<src.Length; i++)
            {
                CapturePart(src[i], dst);
            }
        }
        
        public void CapturePart(IPartCatalog src, TPartCaptureArchive dst)
        {
            if(src.IsNonEmpty)
            {
                Context.Raise(new CapturingPart(src.PartId));
                CaptureHosts(src,dst);
                Context.Raise(new CapturedPart(src.PartId));
            }
        }

        public void CaptureHosts(IPartCatalog src, TPartCaptureArchive dst)
        {
            var step = CaptureHostStep.create(State);             
            z.iter(src.OperationHosts, h => CaptureHost(step, h, dst));
        }

        public void CaptureHost(CaptureHostStep step, IApiHost host, TPartCaptureArchive dst)
        {                
            Context.Raise(new CapturingHost(host.Uri));
            step.Execute(host, dst);
            Context.Raise(new CapturedHost(host.Uri));
        }
    }
}