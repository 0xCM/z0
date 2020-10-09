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
    using static z;

    public sealed class CaptureParts : WfHost<CaptureParts,WfCaptureState>
    {
        protected override void Execute(IWfShell shell, in WfCaptureState state)
        {
            using var step = new CapturePartsStep(state, this);
            step.Run();
        }
    }

    public struct CapturePartsStep : IDisposable
    {
        readonly WfCaptureState State;

        readonly IWfShell Wf;

        public IWfInit Config;

        readonly CorrelationToken Ct;

        readonly ICaptureContext Context;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public CapturePartsStep(WfCaptureState state, WfHost host)
        {
            State = state;
            Host = host;
            Wf = state.Wf;
            Ct = Wf.Ct;
            Config = State.Config;
            Context = State.CWf.Context;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, State.Parts.Format());
            Clear();
            Capture(Archives.capture(Config.TargetArchive.Root));
            Wf.Ran(Host);
        }

        void Capture(IPartCapturePaths dst)
        {
            var catalogs = @readonly(Config.Api.Catalogs);
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                CapturePart(skip(catalogs,i), dst);
        }

        void CapturePart(IApiPartCatalog src, IPartCapturePaths dst)
        {
            if(src.IsEmpty)
                return;

            Context.Raise(new CapturingPart(src.PartId));
            CaptureHosts(src,dst);
            Context.Raise(new CapturedPart(src.PartId));
        }

        void CaptureHosts(IApiPartCatalog src, IPartCapturePaths dst)
        {
            Capture(src.ApiDataTypes, dst);
            Capture(src.OperationHosts, dst);
        }

        void Capture(ApiHost[] src, IPartCapturePaths dst)
        {
            var count = src.Length;
            var hosts = @readonly(src);
            using var step = new CaptureMembersStep(State, new CaptureMembers(), dst);
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                Context.Raise(new CapturingHost(host.Uri, Ct));
                step.Execute(host);
                Context.Raise(new Asm.CapturedHost(host.Uri, Ct));
            }
        }

        void Capture(ApiDataTypes src, IPartCapturePaths dst)
        {
            using var step = new ExtractMembers(Wf, new ExtractMembersHost());
            var extracted = @readonly(step.Extract(src).GroupBy(x => x.Host).Select(x => kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                using var emit = new EmitCaptureArtifactsStep(State, new EmitCaptureArtifacts(), x.Key, x.Value, dst);
                emit.Run();
            }
        }

        void Clear()
        {
            try
            {
                using var step = new ClearCaptureArchivesStep(Wf, new ClearCaptureArchives(), Config);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }
    }
}