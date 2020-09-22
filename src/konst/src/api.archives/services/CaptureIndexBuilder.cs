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

    public class CaptureIndexBuilder : IDisposable
    {
        readonly Dictionary<MemoryAddress,ApiCodeBlock> CodeAddress;

        readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        readonly Dictionary<OpUri,ApiCodeBlock> Locations;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public ApiHexIndex Index;

        public static ApiHexIndex create(IWfShell wf, WfHost host, in PartFiles src)
        {
            var files = src.Parsed.View;
            var count = files.Length;
            var builder = new CaptureIndexBuilder(wf, host);
                wf.Status(host, text.format("Indexing {0} datasets",count));

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(files,i);

                var result = ApiParseReport.load(path);
                if(result)
                {
                    index(wf, host, result.Value, builder);
                    wf.Status(host, text.format("Indexed {0}", path));
                }
                else
                    wf.Error(host, $"Could not parse {path}");
            }

            var status = builder.Status();
            wf.Status(host, text.format("Freeze: {0}", status.Format()));

            builder.Run();
            return builder.Index;
        }

        static void index(IWfShell wf, WfHost host, in ApiParseRow src, CaptureIndexBuilder dst)
        {
            if(src.Address.IsEmpty)
                return;

            var code = new ApiCodeBlock(src.Uri, src.Data);
            var inclusion = dst.Include(code);
            if(inclusion.Any(x => x == false))
                wf.Warn(host, $"Duplicate | {src.Uri.Format()}");
        }

        static void index(IWfShell wf, WfHost host, ReadOnlySpan<ApiParseRow> src, CaptureIndexBuilder dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                index(wf, host, skip(src,i), dst);
        }

        public CaptureIndexBuilder(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            CodeAddress = dict<MemoryAddress,ApiCodeBlock>();
            UriAddress = dict<MemoryAddress,OpUri>();
            Locations = dict<OpUri,ApiCodeBlock>();
        }

        public X86IndexStatus Status()
        {
            var dst = default(X86IndexStatus);
            dst.Parts = Parts;
            dst.Hosts = Hosts;
            dst.Addresses = Addresses;
            dst.MemberCount = MemberCount;
            dst.Encoded = new ApiPartAddresses(dst.Parts, Encoded);
            return dst;
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public PartId[] Parts
            => Locations.Keys.Select(x => x.Host.Owner).Distinct().Array();

        public ApiHostUri[] Hosts
            => Locations.Keys.Select(x => x.Host).Distinct().Array();

        public MemoryAddress[] Addresses
            => CodeAddress.Keys.Array();

        public uint MemberCount
            => (uint)CodeAddress.Keys.Count;

        public KeyValuePairs<MemoryAddress,ApiCodeBlock> Encoded
            => CodeAddress.ToKVPairs();

        public KeyValuePairs<MemoryAddress,OpUri> Located
            => UriAddress.ToKVPairs();

        public void Run()
        {
            Index = Freeze();
        }

        ApiHexIndex Freeze()
        {
            var memories = Encoded;
            var locations = Located;
            var parts = Parts;
            var code = CodeAddress.Values.Select(x => (x.Uri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new X86HostCode(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new ApiHexIndex(parts,
                   new ApiPartAddresses(parts, memories),
                   new ApiUriAddresses(parts, locations),
                   new X86PartCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()));
        }

        public Triple<bool> Include(in ApiCodeBlock src)
        {
            var a = CodeAddress.TryAdd(src.Base, src);
            var b = UriAddress.TryAdd(src.Base, src.Uri);
            var c = Locations.TryAdd(src.Uri, src);
            return (a,b,c);
        }
    }
}