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

    using static Part;
    using static memory;
    using static ProcessMemory;

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

        Index<SegmentSelection> LogSegmentSelection(uint step)
        {
            var regions = ImageMemory.regions();
            TableEmit(regions.View, Db.IndexTable<MemoryRegion>(string.Format("regions.{0}", step)));
            var selection = ImageMemory.selection(Wf,regions);
            TableEmit(selection.View, Db.IndexTable<SegmentSelection>(step.ToString()));
            return selection;
        }

        void LogResolutions(ReadOnlySpan<ResolvedPart> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(src,i);
                LogResolutions(part);
            }
        }

        void LogResolutions(in ResolvedPart src)
        {
            var hosts = src.Hosts.View;
            var count = hosts.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
            }
        }

        void LogResolutions(in ResolvedHost src)
        {
            var methods = src.Methods.View;
            var count = methods.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);

            }
        }
        public void Run()
        {
            var s0 = LogSegmentSelection(0);
            var catalog = ResolveCatalog();
            LogResolutions(catalog);
            var s1 = LogSegmentSelection(1);

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

        void EmitRebase(ApiMembers members, Timestamp ts)
        {
            var rebasing = Wf.Running();
            var dst = Paths.ApiRebasePath(ts);
            var entries = Wf.ApiCatalogs().RebaseMembers(members, dst);
            Wf.Ran(rebasing);
        }

        void EmitContext()
        {
            var dir = Paths.ContextRoot();
            var ts = root.timestamp();
            var process = Process.GetCurrentProcess();
            var pipe = Wf.ProcessContextPipe();
            var summaries = pipe.EmitPartitions(process, ts);
            var details = pipe.EmitRegions(process, ts);
            var members = ApiMembers.create(HostDatasets.ToArray().SelectMany(x => x.Members));
            EmitRebase(members,ts);
        }
    }
}