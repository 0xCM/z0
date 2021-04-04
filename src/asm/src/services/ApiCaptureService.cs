//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.IO;

    using Z0.Asm;

    using static Part;
    using static memory;

    public sealed class ApiCaptureService : WfService<ApiCaptureService>
    {
        ApiMemberExtractor Extractor;

        ApiServices Services;

        ApiCaptureEmitter Emitter;

        ApiJit Jitter;

        protected override void OnInit()
        {
            Extractor = Wf.MemberExtractor();
            Services = Wf.ApiServices();
            Emitter = Wf.CaptureEmitter();
            Jitter = Wf.ApiJit();
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

        public Index<AsmMemberRoutines> CaptureApiCatalog(IApiCatalogDataset catalog)
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
            Wf.ApiCaptureArchive().Clear();
        }

        void ClearArchive(Index<PartId> parts)
        {
            Wf.ApiCaptureArchive().Clear(parts);
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

        public Index<AsmMemberRoutines> CaptureHosts(ReadOnlySpan<ApiHostUri> src)
        {
            var dst = root.list<AsmMemberRoutines>();
            try
            {
                var hosts = Wf.Api.FindHosts(src);
                var count = hosts.Length;
                var view = hosts.View;
                for(var i=0; i<count; i++)
                {
                    var host = skip(view,i);
                    dst.Add(CaptureHost(host));
                }
            }
            catch(IOException e)
            {
                Wf.Error(string.Format("IOException: {0}", e.Message));
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

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

        public AsmMemberRoutines CaptureHost(IApiHost src)
        {
            src = root.require(src);
            var routines = AsmMemberRoutines.Empty;
            var flow = Wf.Running(src.Name);
            try
            {
                routines = Emitter.Emit(src.Uri, ExtractHostOps(src));
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(flow, src.Name);
            return routines;
        }

        public AsmMemberRoutines CaptureHost(IApiHost src, FS.FolderPath dst)
        {
            src = root.require(src);
            var routines = AsmMemberRoutines.Empty;
            var flow = Wf.Running(src.Name);
            try
            {
                routines = Emitter.Emit(src.Uri, ExtractHostOps(src));
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            Wf.Ran(flow, src.Name);
            return routines;
        }

        public Index<ApiMemberExtract> ExtractHostOps(IApiHost host)
        {
            try
            {
                return Extractor.Extract(Jitter.JitHost(host));
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