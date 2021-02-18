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

    using static Part;
    using static z;

    public struct ApiCaptureService : IDisposable
    {
        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly WfHost Host;

        readonly ApiMemberExtractor Extractor;

        readonly IApiJit Jitter;

        [MethodImpl(Inline)]
        public ApiCaptureService(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(nameof(ApiCaptureService));
            Wf = wf.WithHost(Host);
            Asm = asm;
            Wf.Created();
            Extractor = ApiCodeExtractors.service();
            Jitter = Wf.ApiServices.ApiJit();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void CaptureApi()
        {
            using var flow = Wf.Running();
            ClearArchive();
            RunCapture();
            Wf.Ran(flow);
        }

        void RunCapture()
        {
            using var flow = Wf.Running();
            var catalogs = Wf.Api.Catalogs.View;
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                CapturePart(skip(catalogs,i));
            Wf.Ran(flow, count);

        }
        void ClearArchive()
        {
            using var archive = ApiArchives.capture(Wf);
            archive.Clear();
        }

        public void CapturePart(IApiPartCatalog src)
        {
            if(src.IsEmpty)
                return;

            CaptureTypes(src.ApiTypes);
            CaptureHosts(src.OperationHosts);
        }

        public void CaptureHosts(ReadOnlySpan<ApiHost> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                CaptureHost(skip(src, i));
        }

        public AsmRoutines CaptureHost(IApiHost api)
        {
            var routines = AsmRoutines.Empty;
            var flow = Wf.Running(api.Name);
            try
            {
                var ops = ExtractHostOps(api);
                var emitter = Capture.emitter(Wf, Asm);
                routines = emitter.Emit(api.Uri, ops);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(flow, api.Name);
            return routines;
        }

        public Index<ApiMemberExtract> ExtractHostOps(IApiHost host)
        {
            try
            {
                return Extractor.Extract(Jitter.Jit(host));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }

        public AsmRoutines CaptureTypes(Index<ApiRuntimeType> src)
        {
            var dst = root.list<AsmRoutine>();
            var extracted = @readonly(ExtractTypes(src).GroupBy(x => x.Host).Select(x => root.kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                var emititter = Capture.emitter(Wf, Asm);
                dst.AddRange(emititter.Emit(x.Key, x.Value));
            }
            return dst.ToArray();
        }

        Index<ApiMemberExtract> ExtractTypes(Index<ApiRuntimeType> types)
        {
            try
            {
                return Extractor.Extract(Jitter.Jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }
    }
}