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
    using static Typed;

    [ApiHost]
    public partial class ApiExtractor : AppService<ApiExtractor>
    {
        ApiExtractParser Parser;

        ApiResolver Resolver;

        AsmDecoder Decoder;

        AsmFormatter Formatter;

        HexPacks HexPacks;

        ApiExtractReceipt Receivers;

        ConcurrentBag<ApiHostDataset> HostDatasets;

        ApiExtractPaths Paths;

        byte[] Buffer;

        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            Exclusions = root.hashset(root.array("ToString","GetHashCode", "Equals", "ToString"));
        }

        protected override void OnInit()
        {
            Parser = ApiExtracts.parser();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
            HexPacks = Wf.HexPacks();
            Receivers = new ApiExtractReceipt();
            HostDatasets = new();
            Paths = new ApiExtractPaths(Db.AppLogRoot());
        }

        void Run3()
        {
            var selected = root.hashset(PartId.Cpu, PartId.Math, PartId.GMath);
            var flow = Wf.Running(string.Format("Exracting parts {0}", selected.Delimit(Chars.Comma)));
            var catalog = Wf.ApiCatalog;
            var parts = catalog.Parts.Where(p => selected.Contains(p.Id));
            var count = parts.Length;
            var resolved = @readonly(parts.Select(ResolvePart));
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(resolved,i);
                counter += ExtractPart(part);
            }
            Wf.Ran(flow, string.Format("Extracted {0} host routines from {1} parts", counter, selected.Count));
        }

        FS.FolderPath SegDir
            => Db.TableDir("segments");

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

        FS.FolderPath BinDir
            => Db.TableDir("image.bin");

        void RunExtractor(ReadOnlySpan<PartId> src)
        {
            var s0 = LogSegments(0);
            var resolved = ResolveParts(src);
            var methods = LogResolutions(resolved);
            var regions = LogRegions(1);
            var s1 = LogSegments(1, regions);
            var segments = LocateSegments(s1, methods);
            Wf.SegmentTraverser().Traverse(segments, BinDir);
        }

        void RunExtractor()
        {
            RunExtractor(Wf.ApiCatalog.PartIdentities);
        }

        public void Run(params PartId[] parts)
        {
            var flow = Wf.Running(nameof(ApiExtractor));

            Wf.Babble("Clearing output directories");
            SegDir.Clear();
            BinDir.Clear();

            if(parts.Length != 0)
                RunExtractor(@readonly(parts));
            else
                RunExtractor();

            Wf.Ran(flow,nameof(ApiExtractor));
            //HostDatasets.Clear();
            // Paths.Root.Clear(true);
            // Run3();
        }

        public void Run(ApiExtractReceipt receivers, FS.FolderPath? dst = null)
        {
            Receivers = receivers;
            if(dst != null)
            Paths = new ApiExtractPaths(dst.Value);
            Run();
            EmitContext();
        }
    }
}