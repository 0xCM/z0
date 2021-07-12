//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;
    using System.Diagnostics;

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

        Index<AsmRoutine> SortedRoutines;

        AsmFormatConfig FormatConfig;

        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            SortedRoutines = array<AsmRoutine>();
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

        void ClearTargets()
        {
            Paths.ExtractRoot().Clear();
            Paths.AsmSourceRoot().Clear(true);
        }

        public void ExtractParts()
        {
            ExtractParts(ResolvedParts, false);
        }

        void EmitContext(IApiPack pack)
        {
            if(pack.Settings.EmitContext)
                EmitProcessContext(pack);
        }

        void EmitAnalyses(IApiPack pack)
        {
            if(pack.Settings.Analyze)
                Wf.AsmAnalyzer().Analyze(SortedRoutines, Paths);
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