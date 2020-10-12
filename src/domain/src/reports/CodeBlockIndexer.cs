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

    public class CodeBlockIndexer : IDisposable
    {
        readonly Dictionary<MemoryAddress,ApiCodeBlock> CodeAddress;

        readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        readonly Dictionary<OpUri,ApiCodeBlock> Locations;

        readonly IWfShell Wf;

        readonly WfHost Host;

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        internal CodeBlockIndexer(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            CodeAddress = dict<MemoryAddress,ApiCodeBlock>();
            UriAddress = dict<MemoryAddress,OpUri>();
            Locations = dict<OpUri,ApiCodeBlock>();
        }

        public static ApiCodeBlockIndex index(IWfShell wf, WfHost host, in PartFiles src)
        {
            var files = src.Parsed.View;
            var count = files.Length;
            var builder = new CodeBlockIndexer(wf, host);
                wf.Status(host, text.format("Indexing {0} datasets",count));

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(files,i);

                var result = ApiParseReport.load(path);
                if(result)
                {
                    include(wf, host, result.Value, builder);
                    wf.Status(host, text.format("Indexed {0}", path));
                }
                else
                    wf.Error(host, $"Could not parse {path}");
            }

            var status = builder.Status();
            wf.Status(host, text.format("Freeze: {0}", status.Format()));
            return builder.Freeze();
        }

        internal static void include(IWfShell wf, WfHost host, in ApiParseBlock src, CodeBlockIndexer dst)
        {
            if(src.Address.IsEmpty)
                return;

            var code = new ApiCodeBlock(src.Uri, src.Data);
            var inclusion = dst.Include(code);
            if(inclusion.Any(x => x == false))
                wf.Warn(host, $"Duplicate | {src.Uri.Format()}");
        }

        internal static void include(IWfShell wf, WfHost host, ReadOnlySpan<ApiParseBlock> src, CodeBlockIndexer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                include(wf, host, skip(src,i), dst);
        }

        internal CaptureIndexStatus Status()
        {
            var dst = default(CaptureIndexStatus);
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
            var locations = UriAddress.ToKVPairs();
            var parts = Locations.Keys.Select(x => x.Host.Owner).Distinct().Array();
            var code = CodeAddress.Values.Select(x => (x.Uri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new CodeBlocks(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new ApiCodeBlockIndex(
                   new PartAddresses(parts, memories),
                   new UriAddresses(parts, locations),
                   new PartCode(parts, code.Select(x => (x.Host, x)).ToDictionary()));
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