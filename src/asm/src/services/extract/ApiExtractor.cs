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

        AsmFormatter Formatter;

        ApiHexPacks HexPacks;

        ApiExtractChannel Receivers;

        ConcurrentBag<ApiHostDataset> DatasetReceiver;

        Index<ApiHostDataset> CollectedDatasets;

        ApiPackArchive Paths;

        byte[] Buffer;

        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        ApiCatalogs Catalogs;

        Index<IPart> SelectedParts;

        Index<ResolvedPart> ResolvedParts;

        Index<AsmRoutine> Routines;

        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            Exclusions = root.hashset(core.array("ToString","GetHashCode", "Equals", "ToString"));
            Routines = sys.empty<AsmRoutine>();
            ResolvedParts = sys.empty<ResolvedPart>();
        }

        protected override void OnInit()
        {
            Parser = ApiExtracts.parser();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
            HexPacks = Wf.ApiHexPacks();
            Receivers = new ApiExtractChannel();
            DatasetReceiver = new();
            Catalogs = Wf.ApiCatalogs();
            SelectedParts = Wf.ApiCatalog.Parts;
        }

        void SealCollected()
        {
            CollectedDatasets = DatasetReceiver.Array();
            Routines = CollectedDatasets.SelectMany(x => x.Routines.Where(r => r != null && r.IsNonEmpty));
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
            var entries = Catalogs.RebaseMembers(members, Paths.ApiRebasePath(ts));
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

        void Analyze()
        {
            Wf.AsmAnalyzer().Analyze(Routines, Paths.RootDir());
        }


        void RunWorkflow(IApiPack pack)
        {
            Paths.ExtractRoot().Clear();
            Paths.AsmSourceRoot().Clear(true);

            ResolvedParts = SelectedParts.Map(Resolver.ResolvePart);
            ExtractParts(ResolvedParts, false);

            SealCollected();

            if(pack.Settings.EmitContext)
                EmitProcessContext(pack);

            if(pack.Settings.Analyze)
                Analyze();
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

        public static MsgPattern<Count> CreatingStatements => "Creating {0} statements";

        public static MsgPattern<Count> CreatedStatements => "Created {0} statements";
    }
}