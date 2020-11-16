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

    public readonly struct ApiPartCapture
    {
        static WfHost Host => WfShell.host(typeof(ApiPartCapture));

        public static void capture(IAsmWf asm, IApiPartCatalog src)
        {
            if(src.IsEmpty)
                return;

            capture(asm, src.ApiDataTypes);
            capture(asm, src.OperationHosts);
        }

        public static void capture(IAsmWf asm, ApiHost[] src)
        {
            var count = src.Length;
            var hosts = @readonly(src);
            for(var i=0; i<count; i++)
                CaptureApiHost.create(asm, skip(hosts,i)).Run(asm.Wf);
        }

        public static void capture(IAsmWf asm, ApiDataTypes src)
        {
            using var step = new ExtractMembers(asm.Wf, Host);
            var extracted = @readonly(step.Extract(src).GroupBy(x => x.Host).Select(x => kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                using var emit = new EmitCaptureArtifactsStep(asm, Host, x.Key, x.Value);
                emit.Run();
            }
        }
    }

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
            Wf = state.Wf.WithHost(Host);
            Ct = Wf.Ct;
            Config = State.Config;
            Context = State.CWf.Context;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();

            ClearCaptureArchives.create().Run(Wf);

            var catalogs = Config.Api.Catalogs.Terms;
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                CapturePart(skip(catalogs,i));
        }

        void CapturePart(IApiPartCatalog src)
        {
            if(src.IsEmpty)
                return;

            Capture(src.ApiDataTypes);
            Capture(src.OperationHosts);
        }

        void Capture(ApiHost[] src)
        {
            var count = src.Length;
            var hosts = @readonly(src);
            for(var i=0; i<count; i++)
                CaptureApiHost.create(State, skip(hosts,i)).Run(Wf);
        }

        void Capture(ApiDataTypes src)
        {
            using var step = new ExtractMembers(Wf, Host);
            var extracted = @readonly(step.Extract(src).GroupBy(x => x.Host).Select(x => kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                using var emit = new EmitCaptureArtifactsStep(State, Host, x.Key, x.Value);
                emit.Run();
            }
        }
    }
}