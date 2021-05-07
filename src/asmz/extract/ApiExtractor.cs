//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Collections.Concurrent;
    using System.Diagnostics;

    using static memory;

    [ApiHost]
    partial class ApiExtractor : AppService<ApiExtractor>
    {
        ApiExtractParser Parser;

        Z0.ApiExtractor Extractor;

        ApiResolver Resolver;

        AsmRoutineDecoder Decoder;

        AsmFormatter Formatter;

        HexPacks HexPacks;

        ApiExtractReceivers Receivers;

        ConcurrentBag<ApiHostDataset> HostDatasets;

        ExtractPaths Paths;

        protected override void OnInit()
        {
            Parser = ApiExtracts.parser();
            Extractor = Wf.ApiExtractor();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
            HexPacks = Wf.HexPacks();
            Receivers = new ApiExtractReceivers();
            HostDatasets = new();
            Paths = new ExtractPaths(Db.AppLogRoot());
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

        public void Run()
        {
            HostDatasets.Clear();
            Paths.Root.Clear(true);
            Run3();
        }

        public void Run(ApiExtractReceivers receivers, FS.FolderPath? dst = null)
        {
            Receivers = receivers;
            if(dst != null)
            Paths = new ExtractPaths(dst.Value);
            Run();
            EmitContext();
        }

        void EmitRebase(ApiMembers members, Timestamp ts)
        {
            var rebasing = Wf.Running();
            var dst = Paths.ApiRebasePath(ts);
            var entries = Wf.ApiData().RebaseMembers(members, dst);
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