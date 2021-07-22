//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;

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

        ApiExtractChannel Channel;

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
            Channel = new ApiExtractChannel();
            DatasetReceiver = new();
        }

        void ClearTargets()
        {
            Paths.ExtractRoot().Clear();
            Paths.AsmRoot().Clear(true);
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

        ApiCollection CollectAll()
        {
            var collection = new ApiCollection();
            collection._ResolvedParts = ResolvedParts;
            return collection;
        }

        internal ApiCollection Run(ApiExtractChannel receivers, IApiPack pack)
        {
            Channel = receivers;
            Paths = ApiPackArchive.create(pack.Root);
            RedirectEmissions("capture", pack.Root);
            RunWorkflow(pack);
            return CollectAll();
        }
    }
}