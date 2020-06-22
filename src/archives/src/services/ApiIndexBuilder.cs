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

    public readonly struct ApiIndexBuilder : IApiIndexBuilder
    {
        readonly IApiSet ApiSet;

        readonly IMemberLocator Locator;
                
        [MethodImpl(Inline)]
        internal ApiIndexBuilder(IApiSet api, IMemberLocator locator)
        {
            this.ApiSet = api;
            this.Locator = locator;
        }
        
        public ApiCodeIndex CreateIndex(ApiHostUri uri, FilePath src)
        {
            var code = EncodedHexReader.Service.Read(src).ToArray();
            var host = ApiSet.FindHost(uri).Require();
            var members = Locator.Hosted(host);
            var codeIndex =  UriHexQuery.Service.CreateIndex(code);
            var memberIndex = ApiIndex.Create(members);
            return CreateIndex(memberIndex, codeIndex);
        }

        public ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<IdentifiedCode> code)
        {
            var apicode = from pair in members.Intersect(code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select new ApiCode(r.left, r.right);                                      
            return new ApiCodeIndex(apicode.Select(c => (c.Id, c)).ToOpIndex());
        }


        static TArchives Services => Archives.Services;

        public static ApiCodeIndex create(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var indexer =  Services.IndexBuilder(api,locator);
            var members = locator.Hosted(api.FindHost(host).Require());
            var apiIndex = ApiIndex.Create(members);
            var archive =  Services.CaptureArchive(root);
            var paths = archive.HostArchive(host);
            var code = EncodedHexReader.Service.Read(paths.HexPath);
            var opIndex =  UriHexQuery.Service.CreateIndex(code);
            return indexer.CreateIndex(apiIndex, opIndex);            
        }                
    }
}