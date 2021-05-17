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

        FS.FolderPath SegDir
            => Db.TableDir("segments");

        AddressBank LogSegmentBank(uint step)
        {
            var regions = ImageMemory.regions();
            TableEmit(regions.View, Db.Table<ProcessMemoryRegion>(SegDir, step.ToString()));
            var bank = ImageMemory.bank(Wf, regions);
            TableEmit(bank.Segments, Db.Table<ProcessSegment>(SegDir, step.ToString()));
            return bank;
        }

        Index<ResolvedMethodInfo> LogResolutions(ReadOnlySpan<ResolvedPart> src)
        {
            var methods = ApiResolutions.methods(src);
            var buffer = alloc<ResolvedMethodInfo>(methods.Count);
            ApiResolutions.describe(methods,buffer);
            TableEmit(buffer, Db.Table<ResolvedMethodInfo>(SegDir));
            return buffer;
        }

        [Record(TableId)]
        public struct MethodBankEntry : IRecord<MethodBankEntry>
        {
            public const string TableId = "methods.bank";

            public uint Sequence;

            public Address16 Selector;

            public uint SegmentIndex;

            public MemoryAddress EntryPoint;

            public utf8 Uri;
        }

        Index<MethodBankEntry> Locate(AddressBank src, ReadOnlySpan<ResolvedMethodInfo> methods)
        {
            var count = methods.Length;
            var buffer = sys.alloc<MethodBankEntry>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var method = ref skip(methods,i);
                ref readonly var address = ref method.EntryPoint;
                var selector = address.Quadrant(n2);
                var index = src.SelectorIndex(selector);
                if(index == NotFound)
                {
                    Wf.Error(string.Format("Selector {0} not found", selector));
                    break;
                }

                ref var entry = ref seek(dst,i);
                entry.Sequence = i;
                entry.EntryPoint = address;
                entry.Selector = selector;
                entry.Uri = method.Uri;
                var bases = src.Bases((ushort)index);
                var match = address.Lo;

                for(var j=0u; j<bases.Length; j++)
                {
                    ref readonly var @base = ref skip(bases,j);
                    var min = @base.Left;
                    var max = min + @base.Right;
                    if(between(match, @base.Left,@base.Left + @base.Right))
                    {
                        entry.SegmentIndex = j;
                    }
                }

            }

            TableEmit(buffer, Db.Table<MethodBankEntry>(SegDir));

            return buffer;
        }

        [MethodImpl(Inline)]
        public static bool between(Address32 src, Address32 min, Address32 max)
            => src >= min && src <= max;

        Index<CliBlobHeap> CliBlobs()
        {
            var components = Wf.ApiCatalog.Components.View;
            var count = components.Length;
            var buffer = alloc<CliBlobHeap>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var component = ref skip(components,i);
                var reader = Cli.reader(component);
                seek(dst,i) = reader.BlobHeap();
            }
            return buffer;
        }

        public void Run()
        {
            SegDir.Clear();
            var b0 = LogSegmentBank(0);
            var catalog = ResolveCatalog();
            var descriptions = LogResolutions(catalog);
            var b1 = LogSegmentBank(1);
            var entries = Locate(b1, descriptions);

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