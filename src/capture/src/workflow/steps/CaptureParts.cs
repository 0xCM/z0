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

    public struct PartCaptureService : IDisposable
    {
        public static PartCaptureService create(IWfShell wf, IAsmContext asm)
            => new PartCaptureService(wf, WfShell.host(typeof(PartCaptureService)), asm);

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public PartCaptureService(IWfShell wf, WfHost host, IAsmContext asm)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Asm = asm;
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

            var catalogs = Wf.Api.Catalogs.View;
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
                CaptureApiHost.create(Asm, skip(hosts,i)).Run(Wf);
        }

        void Capture(ApiDataTypes src)
        {
            using var step = new ExtractMembers(Wf, Host);
            var extracted = @readonly(step.Extract(src).GroupBy(x => x.Host).Select(x => kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                using var emit = new EmitCaptureArtifactsStep(Wf, Host, Asm, x.Key, x.Value);
                emit.Run();
            }
        }
    }
}