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

    using static z;

    public class ApiIndexService : WfService<ApiIndexService,IApiIndexService>
    {
        public ApiCodeBlockIndex Product;

        public ApiIndexStatus IndexStatus;

        Dictionary<MemoryAddress,ApiCodeBlock> CodeAddress;

        Dictionary<MemoryAddress,OpUri> UriAddress;

        Dictionary<OpUri,ApiCodeBlock> Locations;

        public ApiIndexService()
        {
            CodeAddress = dict<MemoryAddress,ApiCodeBlock>();
            UriAddress = dict<MemoryAddress,OpUri>();
            Locations = dict<OpUri,ApiCodeBlock>();
            Product = ApiCodeBlockIndex.Empty;
        }

        public ApiCodeBlockIndex CreateIndex()
        {
            var src = Wf.Db().PartFiles();
            Wf.Status(src);
            var parsed = src.Parsed.View;
            var count = parsed.Length;
            Wf.Status(Msg.IndexingPartFiles.Format(count));

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(parsed,i);
                var result = ApiParseBlocks.load(path);
                if(result)
                {
                    var blocks = result.Value;
                    Include(blocks);
                    Wf.Status(Msg.AbsorbedCodeBlocks.Format(blocks.Length, path));
                }
                else
                    Wf.Error(Msg.Unparsed(path));
            }

            IndexStatus = Status();
            Wf.Status(IndexStatus.Format());
            Product = Freeze();

            var metrics = ApiIndexMetrics.from(Product);
            Wf.Status(metrics);
            return Product;
        }

        void Include(in ApiParseBlock src)
        {
            if(src.Address.IsEmpty)
            {
                Wf.Warn(Msg.Unbased.Format(src.Uri));
                return;
            }

            var inclusion = Include(new ApiCodeBlock(src.Uri, src.Data));
            if(inclusion.Any(x => x == false))
                Wf.Warn(Msg.DuplicateUri.Format(src.Uri));
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
            dst.Encoded = new PartCodeAddresses(dst.Parts, CodeAddress.ToKVPairs());
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
                   new PartCodeAddresses(parts, memories),
                   new PartUriAddresses(parts, UriAddress),
                   new PartCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()));
        }
    }
}