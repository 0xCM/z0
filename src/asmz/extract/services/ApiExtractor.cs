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

    public struct ApiExtractOptions
    {
        public bool EmitContext;

        public bool Analyze;
    }

    [ApiHost]
    public partial class ApiExtractor : AppService<ApiExtractor>
    {
        ApiExtractParser Parser;

        ApiResolver Resolver;

        AsmDecoder Decoder;

        AsmFormatter Formatter;

        HexPacks HexPacks;

        ApiExtractChannel Receivers;

        ConcurrentBag<ApiHostDataset> HostDatasets;

        Index<ApiHostDataset> CollectedData;

        ApiExtractPaths Paths;

        byte[] Buffer;

        HashSet<string> Exclusions;

        IMultiDiviner Identity {get;}

        ApiCatalogs Catalogs;

        ApiExtractOptions Options;

        Index<IPart> SelectedParts;


        public ApiExtractor()
        {
            Identity = MultiDiviner.Service;
            Buffer = ApiExtracts.buffer();
            Exclusions = root.hashset(root.array("ToString","GetHashCode", "Equals", "ToString"));
            Options.Analyze = true;
        }

        protected override void OnInit()
        {
            Parser = ApiExtracts.parser();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
            HexPacks = Wf.HexPacks();
            Receivers = new ApiExtractChannel();
            HostDatasets = new();
            Catalogs = Wf.ApiCatalogs();
            Paths = new ApiExtractPaths(Db.AppLogRoot());
            SelectedParts = Wf.ApiCatalog.Parts;
        }

        void SealCollected()
        {
            CollectedData = HostDatasets.Array();
        }

        void EmitProcessContext()
        {
            var flow = Wf.Running("Emitting process context");
            var dir = Paths.ContextRoot();
            var ts = root.timestamp();
            var process = Process.GetCurrentProcess();
            var pipe = Wf.ProcessContextPipe();
            var procparts = pipe.EmitPartitions(process, ts, dir);
            var regions = pipe.EmitRegions(process, ts, dir);
            var members = ApiMembers.create(CollectedData.SelectMany(x => x.Members));
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
            Wf.AsmAnalyzer().Analyze(CollectedData.SelectMany(x => x.Routines), Paths.AsmTableRoot());
        }

        void RunWorkflow()
        {
            Paths.ExtractRoot().Clear();
            Paths.AsmSourceRoot().Clear(true);

            var resolved = SelectedParts.Map(Resolver.ResolvePart);
            ExtractParts(resolved, false);

            SealCollected();

            if(Options.EmitContext)
                EmitProcessContext();

            if(Options.Analyze)
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

        // void RunExtractor()
        // {
        //     RunExtractor(Wf.ApiCatalog.PartIdentities);
        // }

        // public void Run(params PartId[] parts)
        // {
        //     var flow = Wf.Running(nameof(ApiExtractor));

        //     Wf.Babble("Clearing output directories");
        //     SegDir.Clear();
        //     BinDir.Clear();

        //     if(parts.Length != 0)
        //         RunExtractor(@readonly(parts));
        //     else
        //         RunExtractor();

        //     Wf.Ran(flow,nameof(ApiExtractor));
        // }

        internal void Run(ApiExtractChannel receivers, FS.FolderPath? dst = null)
        {
            Receivers = receivers;
            if(dst != null)
            Paths = new ApiExtractPaths(dst.Value);
            RunWorkflow();
        }
    }
}