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

    using static memory;

    using api = ApiIndex;

    [Service(typeof(IApiIndex))]
    public class ApiIndexService : WfService<ApiIndexService,IApiIndex>, IApiIndex
    {
        public ApiCodeBlocks Product;

        public ApiIndexStatus IndexStatus;

        Dictionary<MemoryAddress,ApiCodeBlock> CodeAddress;

        Dictionary<MemoryAddress,OpUri> UriAddress;

        Dictionary<OpUri,ApiCodeBlock> Locations;

        public ApiIndexService()
        {
            CodeAddress = root.dict<MemoryAddress,ApiCodeBlock>();
            UriAddress = root.dict<MemoryAddress,OpUri>();
            Locations = root.dict<OpUri,ApiCodeBlock>();
            Product = ApiCodeBlocks.Empty;
        }

        public ApiCodeBlocks IndexApiBlocks()
        {
            var src = Wf.Db().ParsedExtractFiles().View;
            var count = src.Length;
            var flow = Wf.Running(Msg.IndexingPartFiles.Format(count));

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var inner = Wf.Running($"Indexing blocks from {path}");
                var result = ApiCode.hexrows(path);
                if(result.Count != 0)
                {
                    var blocks = result.View;
                    Include(blocks);
                    Wf.Ran(inner, Msg.AbsorbedCodeBlocks.Format(blocks.Length, path));
                }
                else
                    Wf.Error(Msg.Unparsed(path));
            }

            IndexStatus = Status();
            Wf.Status(IndexStatus.Format());
            Product = Freeze();

            Wf.Ran(flow, api.metrics(Product));
            return Product;
        }

        void Include(in ApiHexRow src)
        {
            if(src.Address.IsEmpty)
            {
                Wf.Warn(Msg.Unbased.Format(src.Uri));
                return;
            }

            var inclusion = Include(new ApiCodeBlock(src.Address, src.Uri, src.Data));
            if(inclusion.Any(x => x == false))
                Wf.Warn(Msg.DuplicateUri.Format(src.Uri));
        }

        Triple<bool> Include(in ApiCodeBlock src)
        {
            var a = CodeAddress.TryAdd(src.BaseAddress, src);
            var b = UriAddress.TryAdd(src.BaseAddress, src.Uri);
            var c = Locations.TryAdd(src.Uri, src);
            return root.triple(a,b,c);
        }

        void Include(ReadOnlySpan<ApiHexRow> src)
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
            dst.Encoded = new PartCodeAddresses(dst.Parts, CodeAddress.ToKVPairs());
            return dst;
        }

        ApiCodeBlocks Freeze()
        {
            var memories = CodeAddress.ToKVPairs();
            var parts = Locations.Keys.Select(x => x.Host.Owner).Distinct().Array();
            var code = CodeAddress.Values.Select(x => (x.Uri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new ApiHostCode(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new ApiCodeBlocks(
                   new PartCodeAddresses(parts, memories),
                   new PartUriAddresses(parts, UriAddress),
                   new PartCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()));
        }
    }
}