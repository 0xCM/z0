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
        public static ApiCaptureService create(IWfShell wf, IAsmContext asm)
            => new ApiCaptureService(wf, WfShell.host(typeof(ApiCaptureService)), asm);

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly WfHost Host;

        readonly ApiMemberExtractor Extractor;

        readonly IApiJit Jitter;

        [MethodImpl(Inline)]
        public ApiCaptureService(IWfShell wf, WfHost host, IAsmContext asm)
        {
            Host = host;
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

        public void Run()
        {
            using var flow = Wf.Running();
            ClearArchive();
            var catalogs = Wf.Api.Catalogs.View;
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                Capture(skip(catalogs,i));
            Wf.Ran(flow);
        }

        void ClearArchive()
        {
            using var archive = ApiCaptureArchive.create(Wf);
            archive.Clear();
        }

        void Capture(IApiPartCatalog src)
        {
            if(src.IsEmpty)
                return;

            CaptureTypes(src.ApiTypes);
            CaptureOps(src.OperationHosts);
        }


        void Capture(IApiHost api)
        {
            var flow = Wf.Running(api.Name);
            try
            {
                var extracted = ExtractOps(api);
                var emitter = ApiCaptureEmitter.create(Wf, Asm, api.Uri, extracted);
                emitter.Emit();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(flow, api.Name);
        }

        void CaptureOps(ReadOnlySpan<ApiHost> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Capture(skip(src, i));
        }

        void CaptureTypes(Index<ApiRuntimeType> src)
        {
            var extracted = @readonly(ExtractTypes(src).GroupBy(x => x.Host).Select(x => root.kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                var emititter = ApiCaptureEmitter.create(Wf, Asm, x.Key, x.Value);
                emititter.Emit();
            }
        }

        ApiMemberExtract[] ExtractOps(IApiHost host)
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

        ApiMemberExtract[] ExtractTypes(Index<ApiRuntimeType> types)
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