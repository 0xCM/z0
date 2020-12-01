//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;
    using static ApiCaptureIndexParts;

    public class ApiIndexBuilder : IDisposable
    {
        public ApiCodeBlockIndex Product;

        public ApiIndexStatus IndexStatus;

        readonly Dictionary<MemoryAddress,ApiCodeBlock> CodeAddress;

        readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        readonly Dictionary<OpUri,ApiCodeBlock> Locations;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public ApiIndexBuilder(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            CodeAddress = dict<MemoryAddress,ApiCodeBlock>();
            UriAddress = dict<MemoryAddress,OpUri>();
            Locations = dict<OpUri,ApiCodeBlock>();
            Product = default;
        }

        public void Run()
        {
            var src = DbSvc.partfiles(Wf);
            Wf.Status(src);
            var parsed = src.Parsed.View;
            var count = parsed.Length;
            Wf.Status(text.format("Indexing {0} datasets",count));

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(parsed,i);

                var result = ApiParseBlocks.load(path);
                if(result)
                {
                    var blocks = result.Value;
                    Include(blocks);
                    Wf.Status(text.format("Included {0} blocks from {1}", blocks.Length, path));
                }
                else
                    Wf.Error($"Could not parse {path}");
            }

            IndexStatus = Status();
            Wf.Status(IndexStatus.Format());
            Product = Freeze();
        }

        [MethodImpl(Inline)]
        static Triple<T> triple<T>(T a, T b, T c)
            => new Triple<T>(a,b,c);

        void Include(in ApiParseBlock src)
        {
            if(src.Address.IsEmpty)
            {
                Wf.Warn($"{src.Uri} code has no base address");
                return;
            }

            var inclusion = Include(new ApiCodeBlock(src.Uri, src.Data));
            if(inclusion.Any(x => x == false))
                Wf.Warn($"Duplicate | {src.Uri.Format()}");
        }

        Triple<bool> Include(in ApiCodeBlock src)
        {
            var a = CodeAddress.TryAdd(src.Base, src);
            var b = UriAddress.TryAdd(src.Base, src.Uri);
            var c = Locations.TryAdd(src.Uri, src);
            return triple(a,b,c);
        }

        void Include(ReadOnlySpan<ApiParseBlock> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Include(skip(src, i));
        }

        ApiIndexStatus Status()
        {
            var dst = default(ApiIndexStatus);
            dst.Parts = Locations.Keys.Select(x => x.Host.Owner).Distinct().Array();
            dst.Hosts = Locations.Keys.Select(x => x.Host).Distinct().Array();
            dst.Addresses = CodeAddress.Keys.Array();
            dst.MemberCount = (uint)CodeAddress.Keys.Count;
            dst.Encoded = new PartAddresses(dst.Parts, CodeAddress.ToKVPairs());
            return dst;
        }

        ApiCodeBlockIndex Freeze()
        {
            var memories = CodeAddress.ToKVPairs();
            var parts = Locations.Keys.Select(x => x.Host.Owner).Distinct().Array();
            var code = CodeAddress.Values.Select(x => (x.Uri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new ApiHostCodeBlocks(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new ApiCodeBlockIndex(
                   new PartAddresses(parts, memories),
                   new UriAddresses(parts, UriAddress),
                   new PartCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()));
        }
    }
}