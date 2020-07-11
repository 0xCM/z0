//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiIndexBuilder 
    {
        readonly IApiSet ApiSet;

        readonly IMemberLocator Locator;
                
        [MethodImpl(Inline)]
        public ApiIndexBuilder(IApiSet api, IMemberLocator locator)
        {
            ApiSet = api;
            Locator = locator;        
        }

        public static ApiIndex IndexApi(IEnumerable<ApiMember> src)
        {
            var pairs = src.Select(h => (h.Id, h));
            var opindex = Identify.index(pairs,true);
            return new ApiIndex(opindex.HashTable, opindex.Duplicates);                
        }            

        public ApiCodeIndex IndexCode(ApiHostUri uri, FilePath src)
        {
            var code = EncodedHexReader.Service.Read(src).ToArray();
            var host = ApiSet.FindHost(uri).Require();
            var members = Locator.Locate(host);
            var codeIndex =  UriHexQuery.Service.CreateIndex(code);
            var memberIndex = ApiIndexBuilder.IndexApi(members);
            return ApiCodeIndex.create(memberIndex, codeIndex);
        }        

        static TArchives Services => Archives.Services;

        public static ApiCodeIndex create(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var indexer =  new ApiIndexBuilder(api,locator);
            var members = locator.Locate(api.FindHost(host).Require());
            var apiIndex = IndexApi(members);
            var archive =  Services.CaptureArchive(root);
            var paths =   HostCaptureArchive.Create(root, host);
            var code = EncodedHexReader.Service.Read(paths.HexPath);
            var opIndex =  UriHexQuery.Service.CreateIndex(code);
            return ApiCodeIndex.create(apiIndex, opIndex);            
        }                
    }
}