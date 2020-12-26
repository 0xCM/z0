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
            //ClearCaptureArchives.create().Run(Wf);

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

            Capture(src.ApiDataTypes);
            Capture(src.OperationHosts);
        }

        public void Capture(IApiHost api)
        {
            using var flow = Wf.Running(api.Name);
            try
            {
                // using var extract = new ExtractHostMembersStep(Wf, Host, api);
                // extract.Run();
                var extracted = Extract(api);
                using var emit = ApiCaptureEmitter.create(Wf, Host, Asm, api.Uri, extracted);
                emit.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void Capture(ApiHost[] src)
        {
            var count = src.Length;
            var hosts = @readonly(src);
            for(var i=0; i<count; i++)
                Capture(skip(hosts,i));
        }

        public void Capture(ApiDataTypes src)
        {
            var extracted = @readonly(Extract(src).GroupBy(x => x.Host).Select(x => kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                using var emit = new ApiCaptureEmitter(Wf, Host, Asm, x.Key, x.Value);
                emit.Run();
            }
        }

        public ApiMemberExtract[] Extract(IApiHost host)
        {
            try
            {
                var extractor = ApiCodeExtractors.service(ApiCodeExtractors.DefaultBufferLength);
                return extractor.Extract(ApiJit.jit(host));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }

        public ApiMemberExtract[] Extract(ApiDataTypes types)
        {
            try
            {
                var extractor = ApiCodeExtractors.service(ApiCodeExtractors.DefaultBufferLength);
                return extractor.Extract(ApiJit.jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }
    }
}