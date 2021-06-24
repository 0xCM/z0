//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Concurrent;
    using System.Diagnostics;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Root;
    using static core;

    [ApiHost]
    public partial class ApiExtractor : AppService<ApiExtractor>
    {
        ApiExtractParser Parser;

        ApiResolver Resolver;

        AsmDecoder Decoder;

        ApiHexPacks HexPacks;

        ApiExtractChannel Receivers;

        ConcurrentBag<ApiHostDataset> DatasetReceiver;

        Index<ApiHostDataset> CollectedDatasets;

        ApiPackArchive Paths;

        byte[] Buffer;

        IMultiDiviner Identity {get;}

        Index<ResolvedPart> ResolvedParts;

        Index<AsmRoutine> Routines;

        AsmFormatConfig FormatConfig;

        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            Routines = array<AsmRoutine>();
            ResolvedParts = array<ResolvedPart>();
            FormatConfig = AsmFormatConfig.@default(out var _);
        }

        protected override void OnInit()
        {
            Parser = ApiExtracts.parser();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            HexPacks = Wf.ApiHexPacks();
            Receivers = new ApiExtractChannel();
            DatasetReceiver = new();
        }

        void EmitProcessContext(IApiPack pack)
        {
            var flow = Wf.Running("Emitting process context");
            var ts = pack.Timestamp;
            if(!ts.IsNonZero)
                ts = now();

            var dir = pack.ContextRoot();
            var process = Process.GetCurrentProcess();
            var pipe = Wf.ProcessContextPipe();
            var procparts = pipe.EmitPartitions(process, ts, dir);
            var regions = pipe.EmitRegions(process, ts, dir);
            pipe.EmitDump(process, pack.DumpPath(process, ts));
            var members = ApiMembers.create(CollectedDatasets.SelectMany(x => x.Members));
            var rebasing = Wf.Running();
            var catalogs = Wf.ApiCatalogs();
            var entries = catalogs.RebaseMembers(members, Paths.ApiRebasePath(ts));
            Wf.Ran(rebasing);
            Wf.Ran(flow);
        }

        void CheckExtracts(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(src,i);
                var hosts = part.Hosts.View;
                for(var j=0; j<hosts.Length; j++)
                {
                    ref readonly var host = ref skip(hosts,j);
                    var methods = host.Methods.View;
                    var flow = Wf.Running(string.Format("Extracting {0}", host.Host));
                    for(var k=0; k<methods.Length; k++)
                    {
                        ref readonly var method = ref skip(methods,k);
                        Buffer.Clear();
                        var block = Extract(method, Buffer);
                        counter++;
                    }
                    Wf.Ran(flow, methods.Length);
                }
            }
        }

        void EmitCaptureIndex()
        {
            var dst = Paths.RootDir() + FS.file(Tables.identify<CaptureIndexEntry>().Format(), FS.Csv);
            var src = Routines.View;
            var count = src.Length;
            var buffer = span<CaptureIndexEntry>(count);
            for(var i=0u; i<count; i++)
            {
                ref var entry = ref seek(buffer,i);
                ref readonly var routine = ref skip(src,i);
                entry.Sequence = i;
                entry.BaseAddress = routine.BaseAddress;
                entry.Host = routine.Uri.Host;
                entry.DisplaySig = routine.DisplaySig.Format();
                entry.Uri = routine.Uri;
            }
            TableEmit(@readonly(buffer), CaptureIndexEntry.RenderWidths, dst);
        }

        void ClearTargets()
        {
            Paths.ExtractRoot().Clear();
            Paths.AsmSourceRoot().Clear(true);
        }

        public void ResolveParts()
        {
            var parts = Wf.ApiCatalog.Parts.ToReadOnlySpan();
            var count = parts.Length;
            ResolvedParts = alloc<ResolvedPart>(count);
            ref var dst = ref ResolvedParts.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                var resolution = Resolver.ResolvePart(part);
                seek(dst,i) = resolution;
                Receivers.Raise(new PartResolvedEvent(resolution));
            }
        }

        public void ExtractParts()
        {
            ExtractParts(ResolvedParts, false);
        }

        void CollectRoutines()
        {
            CollectedDatasets = DatasetReceiver.Array();
            Routines = CollectedDatasets.SelectMany(x => x.Routines.Where(r => r != null && r.IsNonEmpty));
            Routines.Sort();
        }

        void EmitContext(IApiPack pack)
        {
            if(pack.Settings.EmitContext)
                EmitProcessContext(pack);
        }

        void EmitAnalyses(IApiPack pack)
        {
            if(pack.Settings.Analyze)
                Wf.AsmAnalyzer().Analyze(Routines, Paths);
        }

        void RunWorkflow(IApiPack pack)
        {
            ClearTargets();
            ResolveParts();
            ExtractParts();
            CollectRoutines();
            EmitContext(pack);
            EmitAnalyses(pack);
        }

        FS.FolderPath SegDir
            => Db.TableDir("segments");

        FS.FolderPath BinDir
            => Db.TableDir("image.bin");

        unsafe ByteSize Emit(in ProcessSegment src)
        {
            var total = 0u;
            var pages = src.PageCount;
            var buffer = default(PageBlock);
            var pSrc = src.Range.Min.Pointer<byte>();
            for(var i=0; i<pages; i++)
            {
                MemoryPages.Read(pSrc, ref buffer);
                pSrc += PageSize;
                total += PageSize;
            }
            return total;
        }

        void RunExtractor(ReadOnlySpan<PartId> src)
        {
            var s0 = LogSegments(0);
            var resolved = Resolver.ResolveParts(src);
            var methods = Resolver.LogResolutions(resolved, SegDir);
            var regions = LogRegions(1);
            var s1 = LogSegments(1, regions);
            var locator = Wf.ApiSegmentLocator();
            var segments = locator.LocateSegments(s1, methods, SegDir);
            Wf.SegmentTraverser().Traverse(segments, BinDir);
        }

        ApiCollection CollectAll()
        {
            var collection = new ApiCollection();
            collection._ResolvedParts = ResolvedParts;
            return collection;
        }

        internal ApiCollection Run(ApiExtractChannel receivers, IApiPack pack)
        {
            Receivers = receivers;
            Paths = ApiPackArchive.create(pack.Root);
            RedirectEmissions("extractor", pack.Root);
            RunWorkflow(pack);
            return CollectAll();
        }
    }
}