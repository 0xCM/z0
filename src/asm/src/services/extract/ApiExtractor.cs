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
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;
    using static core;

    public class ApiCollection
    {
        internal Index<ResolvedPart> _ResolvedParts;

        internal ApiCollection()
        {
            _ResolvedParts = new();
        }

        public ReadOnlySpan<ResolvedPart> ResolvedParts
        {

            [MethodImpl(Inline)]
            get => _ResolvedParts.View;
        }

    }

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

        ApiExtractPaths Paths;

        byte[] Buffer;

        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        ApiCatalogs Catalogs;

        ApiExtractSettings Options;

        Index<IPart> SelectedParts;

        Index<ResolvedPart> ResolvedParts;

        Index<AsmRoutine> Routines;

        IApiPack Pack;

        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            Exclusions = root.hashset(core.array("ToString","GetHashCode", "Equals", "ToString"));
            Options = ApiExtractSettings.Default();
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
            Paths = new ApiExtractPaths(Db.AppLogRoot());
            SelectedParts = Wf.ApiCatalog.Parts;
        }

        void SealCollected()
        {
            CollectedDatasets = DatasetReceiver.Array();
            Routines = CollectedDatasets.SelectMany(x => x.Routines.Where(r => r != null && r.IsNonEmpty));
        }

        void EmitProcessContext()
        {
            var flow = Wf.Running("Emitting process context");
            var ts = Pack.Timestamp;
            var dir = Pack.ContextRoot();
            var process = Process.GetCurrentProcess();
            var pipe = Wf.ProcessContextPipe();
            var procparts = pipe.EmitPartitions(process, ts, dir);
            var regions = pipe.EmitRegions(process, ts, dir);
            pipe.EmitDump(process, Pack.DumpPath(process, ts));

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
            Wf.AsmAnalyzer().Analyze(Routines, Paths.AsmTableRoot());
        }

        uint CountStatements()
        {
            var routines = Routines.View;
            var count = routines.Length;
            var total = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(routines,i);
                total += (uint)routine.InstructionCount;
            }
            return total;

        }

        void EmitStatements()
        {
            var pipe = Wf.AsmStatementPipe();
            var total = CountStatements();
            var running = Wf.Running(CreatingStatements.Format(total));
            var buffer = span<AsmApiStatement>(total);
            var routines = Routines.View;
            var count = routines.Length;
            var offset = 0u;
            for(var i=0; i<count; i++)
                offset += pipe.CreateRecords(skip(routines,i), slice(buffer, offset));

            Wf.Ran(running, CreatedStatements.Format(total));

            pipe.EmitStatements(buffer, Paths.RootDir());
        }

        void RunWorkflow()
        {
            Paths.ExtractRoot().Clear();
            Paths.AsmSourceRoot().Clear(true);

            ResolvedParts = SelectedParts.Map(Resolver.ResolvePart);
            ExtractParts(ResolvedParts, false);

            SealCollected();

            if(Options.EmitContext)
                EmitProcessContext();

            if(Options.Analyze)
                Analyze();

            if(Options.EmitStatements)
                EmitStatements();
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

        internal ApiCollection Run(ApiExtractChannel receivers, FS.FolderPath? dst = null)
        {
            Receivers = receivers;
            if(dst != null)
                Paths = new ApiExtractPaths(dst.Value);
            RunWorkflow();
            return CollectAll();
        }

        ApiCollection CollectAll()
        {
            var collection = new ApiCollection();
            collection._ResolvedParts = ResolvedParts;
            return collection;

        }

        internal ApiCollection Run(ApiExtractChannel receivers, IApiPack dst)
        {
            Pack = dst;
            Receivers = receivers;
            Paths = new ApiExtractPaths(dst.Root);
            RunWorkflow();
            return CollectAll();
        }

        public static MsgPattern<Count> CreatingStatements => "Creating {0} statements";

        public static MsgPattern<Count> CreatedStatements => "Created {0} statements";
    }
}