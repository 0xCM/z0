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
        public static ApiCodeIndex create(IMemberLocator locator, IApiSet api, ApiHostUri uri, FilePath src)
        {
            var code = EncodedHexReader.Service.Read(src).ToArray();
            var host = api.FindHost(uri).Require();
            var members = locator.Locate(host);
            var codeIndex =  UriHexQuery.Service.CreateIndex(code);
            var memberIndex = apiIndex(members);
            return ApiCodeIndex.create(memberIndex, codeIndex);
        }        

        public static ApiCodeIndex create(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var members = locator.Locate(api.FindHost(host).Require());
            var apiIndex = ApiIndexBuilder.apiIndex(members);
            var archive =  Archives.Services.CaptureArchive(root);
            var paths =   HostCaptureArchive.Create(root, host);
            var code = EncodedHexReader.Service.Read(paths.HexPath);
            var opIndex =  UriHexQuery.Service.CreateIndex(code);
            return ApiCodeIndex.create(apiIndex, opIndex);            
        }                

        static ApiIndex apiIndex(IEnumerable<ApiMember> src)
        {
            var opindex = Identify.index(src.Select(h => (h.Id, h)),true);
            return new ApiIndex(opindex.HashTable, opindex.Duplicates);                
        }            

    }
}