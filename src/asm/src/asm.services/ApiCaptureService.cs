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
    using static memory;

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
            var services = wf.ApiServices();

            Jitter = services.ApiJit();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public Index<AsmMemberRoutine> CaptureApi()
        {
            using var flow = Wf.Running();
            ClearArchive();
            var captured = RunCapture();
            Wf.Ran(flow);
            return captured.SelectMany(x => x.Storage);
        }

        Index<AsmMemberRoutines> RunCapture()
        {
            var dst = root.list<AsmMemberRoutines>();
            using var flow = Wf.Running();
            var catalogs = Wf.Api.Catalogs.View;
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(CapturePart(skip(catalogs,i)));
            Wf.Ran(flow, count);
            return dst.ToArray();
        }

        void ClearArchive()
        {
            using var archive = ApiCaptureArchive.create(Wf);
            archive.Clear();
        }

        public Index<AsmMemberRoutines> CapturePart(IApiPartCatalog src)
        {
            if(src.IsEmpty)
                return sys.empty<AsmMemberRoutines>();

            var dst = root.list<AsmMemberRoutines>();
            dst.Add(CaptureTypes(src.ApiTypes));
            dst.AddRange(CaptureHosts(src.OperationHosts));
            return dst.ToArray();
        }

        public Index<AsmMemberRoutines> CaptureHosts(ReadOnlySpan<ApiHost> src)
        {
            var count = src.Length;
            var dst = root.list<AsmMemberRoutines>();
            for(var i=0; i<count; i++)
                dst.Add(CaptureHost(skip(src, i)));
            return dst.ToArray();
        }

        public AsmMemberRoutines CaptureHost(IApiHost api)
        {
            var routines = AsmMemberRoutines.Empty;
            var flow = Wf.Running(api.Name);
            try
            {
                var ops = ExtractHostOps(api);
                var emitter = Wf.CaptureEmitter(Asm);
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

        public AsmMemberRoutines CaptureTypes(Index<ApiRuntimeType> src)
        {
            var dst = root.list<AsmMemberRoutine>();
            var extracted = @readonly(ExtractTypes(src).GroupBy(x => x.Host).Select(x => root.kvp(x.Key, x.Array())).Array());
            for(var i=0; i<extracted.Length; i++)
            {
                ref readonly var x = ref skip(extracted,i);
                var emititter = Wf.CaptureEmitter(Asm);
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