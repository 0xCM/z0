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

    public sealed class ApiCaptureService : WfService<ApiCaptureService>
    {
        ApiMemberExtractor Extractor;

        ApiServices Services;

        ApiCaptureEmitter Emitter;

        protected override void OnInit()
        {
            Extractor = ApiCodeExtractors.service();
            Services = Wf.ApiServices();
            Emitter = Wf.CaptureEmitter(Wf.AsmContext());
        }

        /// <summary>
        /// Root capture routine that traverses and captures the apiset
        /// </summary>
        public Index<AsmMemberRoutine> CaptureApi()
        {
            using var flow = Wf.Running();
            ClearArchive();
            var captured = RunCapture();
            Wf.Ran(flow);
            return captured.SelectMany(x => x.Storage);
        }

        public Index<AsmMemberRoutine> CaptureApi(Index<PartId> parts)
        {
            using var flow = Wf.Running();
            ClearArchive(parts);
            var captured = RunCapture(parts);
            Wf.Ran(flow);
            return captured.SelectMany(x => x.Storage);
        }

        public Index<AsmMemberRoutines> CaptureApiCatalog(IGlobalApiCatalog catalog)
        {
            var dst = root.list<AsmMemberRoutines>();
            using var flow = Wf.Running();
            var catalogs = catalog.Catalogs.View;
            var count = catalogs.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(CapturePart(skip(catalogs,i)));
            Wf.Ran(flow, count);
            return dst.ToArray();

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

        Index<AsmMemberRoutines> RunCapture(Index<PartId> parts)
        {
            var dst = root.list<AsmMemberRoutines>();
            using var flow = Wf.Running();
            var catalogs = Wf.Api.PartCatalogs(parts).View;
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

        void ClearArchive(Index<PartId> parts)
        {
            using var archive = ApiCaptureArchive.create(Wf);
            archive.Clear(parts);
        }

        /// <summary>
        /// Captures a catalog-specified part
        /// </summary>
        /// <param name="src">The part catalog</param>
        public Index<AsmMemberRoutines> CapturePart(IApiPartCatalog src)
        {
            if(src.IsEmpty)
                return sys.empty<AsmMemberRoutines>();

            var dst = root.list<AsmMemberRoutines>();
            dst.Add(CaptureTypes(src.ApiTypes));
            dst.AddRange(CaptureHosts(src.OperationHosts));
            return dst.ToArray();
        }

        public Index<AsmMemberRoutines> CaptureHosts(ReadOnlySpan<IApiHost> src)
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
                routines = Emitter.Emit(api.Uri, ExtractHostOps(api));
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
                return Extractor.Extract(Services.ApiJit.JitHost(host));
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
            var count = extracted.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var extracts = ref skip(extracted,i);
                dst.AddRange(Emitter.Emit(extracts.Key, extracts.Value));
            }
            return dst.ToArray();
        }

        Index<ApiMemberExtract> ExtractTypes(Index<ApiRuntimeType> types)
        {
            try
            {
                return Extractor.Extract(Services.ApiJit.Jit(types));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return sys.empty<ApiMemberExtract>();
            }
        }
    }
}