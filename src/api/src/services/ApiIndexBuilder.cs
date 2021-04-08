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
    using static Part;

    [Service(typeof(IApiIndexBuilder))]
    public class ApiIndexBuilder : WfService<ApiIndexBuilder>, IApiIndexBuilder
    {
        public ApiBlockIndex Product;

        public ApiIndexStatus IndexStatus;

        Dictionary<MemoryAddress,ApiCodeBlock> CodeAddress;

        Dictionary<MemoryAddress,OpUri> AddressUri;

        UriCode UriCode;

        public ApiIndexBuilder()
        {
            CodeAddress = root.dict<MemoryAddress,ApiCodeBlock>();
            AddressUri = root.dict<MemoryAddress,OpUri>();
            UriCode = new UriCode();
            Product = ApiBlockIndex.Empty;
        }

        public ApiMemberIndex CreateMemberIndex(ApiHostCatalog src)
            => ApiIndex.create(src);

        public ApiBlockIndex IndexApiBlocks()
        {
            var src = Db.ParsedExtractPaths().View;
            var count = src.Length;
            var flow = Wf.Running(Msg.IndexingPartFiles.Format(count));
            var hex = Wf.ApiHex();

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var inner = Wf.Running(Msg.IndexingCodeBlocks.Format(path));
                var result = hex.Rows(path);
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
            Product = Freeze();

            Wf.Ran(flow, Product.CalcMetrics());
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
            var b = AddressUri.TryAdd(src.BaseAddress, src.Uri);
            var c = UriCode.TryAdd(src.Uri, src);
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
            dst.Parts = UriCode.Keys.Select(x => x.Host.Part).Distinct().Array();
            dst.Hosts = UriCode.Keys.Select(x => x.Host).Distinct().Array();
            dst.Addresses = CodeAddress.Keys.Array();
            dst.MemberCount = (uint)CodeAddress.Keys.Count;
            dst.Encoded = new PartCodeAddresses(dst.Parts, CodeAddress.ToKVPairs());
            return dst;
        }

        ApiBlockIndex Freeze()
        {
            var memories = CodeAddress.ToKVPairs();
            var parts = UriCode.Keys.Select(x => x.Host.Part).Distinct().Array();
            var code = CodeAddress.Values.Select(x => (x.Uri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new ApiHostCode(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new ApiBlockIndex(
                   new PartCodeAddresses(parts, memories),
                   new PartUriAddresses(parts, AddressUri),
                   new PartCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()),
                   UriCode
                   );
        }
    }
}