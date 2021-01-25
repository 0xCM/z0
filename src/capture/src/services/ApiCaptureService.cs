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

        [MethodImpl(Inline)]
        public ApiCaptureService(IWfShell wf, WfHost host, IAsmContext asm)
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
            ClearArchive();
            var catalogs = Wf.Api.Catalogs.View;
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                Capture(skip(catalogs,i));
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

            Capture(src.ApiTypes);
            Capture(src.OperationHosts);
        }

        void Capture(IApiHost api)
        {
            var flow = Wf.Running(api.Name);
            try
            {
                var extracted = Extract(api);
                var emitter = ApiCaptureEmitter.create(Wf, Asm, api.Uri, extracted);
                emitter.Emit();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(flow, api.Name);
        }

        void Capture(ApiHost[] src)
        {
            var count = src.Length;
            var hosts = @readonly(src);
            for(var i=0; i<count; i++)
                Capture(skip(hosts,i));
        }

        void Capture(Index<ApiTypeInfo> src)
        {
            var extracted = @readonly(Extract(src).GroupBy(x => x.Host).Select(x => root.kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                var emititter = ApiCaptureEmitter.create(Wf, Asm, x.Key, x.Value);
                emititter.Emit();
            }
        }

        ApiMemberExtract[] Extract(IApiHost host)
        {
            try
            {
                var extractor = ApiCodeExtractors.service(ApiCodeExtractors.DefaultBufferLength);
                var jitter = Wf.ApiServices.ApiJit();
                return extractor.Extract(jitter.Jit(host));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }

        ApiMemberExtract[] Extract(Index<ApiTypeInfo> types)
        {
            try
            {
                var extractor = ApiCodeExtractors.service(ApiCodeExtractors.DefaultBufferLength);
                var jitter = Wf.ApiServices.ApiJit();
                return extractor.Extract(jitter.Jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }
    }
}