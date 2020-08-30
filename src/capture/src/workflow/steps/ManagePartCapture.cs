//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static ManagePartCaptureStep;
    using static z;

    public struct ManagePartCapture : IDisposable
    {
        readonly WfCaptureState State;

        readonly IWfContext Wf;

        public IWfConfig Config;

        readonly CorrelationToken Ct;

        readonly ICaptureContext Context;

        [MethodImpl(Inline)]
        public ManagePartCapture(WfCaptureState state, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Config = State.Config;
            Ct = ct;
            Context = State.CWf.Context;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);
            Clear();
            Capture(Archives.capture(Config.TargetArchive.Root));
            Wf.Ran(StepId);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        void Capture(IPartCapturePaths dst)
        {
            var catalogs = @readonly(Config.Api.Catalogs);
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                CapturePart(skip(catalogs,i), dst);
        }

        public void Consolidate()
        {
            Wf.Raise(new RunningConsolidated(StepName, (uint)Config.Api.Catalogs.Length, Ct));

            Clear();

            try
            {
                var dst = Archives.capture(Config.TargetArchive.Root);
                using var step = new CaptureHosts(State, Config.Api.Hosts, dst, Ct);
                step.Run();

            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
           }
        }

        void CapturePart(IPartCatalog src, IPartCapturePaths dst)
        {
            if(src.IsEmpty)
                return;

            Context.Raise(new CapturingPart(src.PartId));
            CaptureHosts(src,dst);
            Context.Raise(new CapturedPart(src.PartId));
        }

        void CaptureHosts(IPartCatalog src, IPartCapturePaths dst)
        {
            var hosts = span(src.Operations);
            var count = hosts.Length;

            using var step = new CaptureHostMembers(State, dst, Ct);
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                Context.Raise(new CapturingHost(host.Uri, Ct));
                step.Execute(host);
                Context.Raise(new Asm.CapturedHost(host.Uri, Ct));
            }
        }

        void Clear()
        {
            try
            {
                using var step = new ClearCaptureArchives(Wf, Config, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
            }
        }
    }
}