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

    public readonly struct ApiMemberOps
    {
        /// <summary>
        /// Creates an operation index from an api member span, readonly that is
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> index<M>(ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => Identify.index(src.MapArray(h => (h.Id, h)));

        public static ApiCodeIndex index(IMemberLocator locator, IApiSet api, ApiHostUri uri, FilePath src)
        {
            var code = EncodedHexReader.Service.Read(src).ToArray();
            var host = api.FindHost(uri).Require();
            var members = locator.Locate(host);
            var codeIndex =  UriHexQuery.Service.CreateIndex(code);
            var memberIndex = index(members);
            return ApiCodeIndex.create(memberIndex, codeIndex);
        }

        public static ApiCodeIndex index(IMemberLocator locator, IApiSet api, ApiHostUri host, FolderPath root)
        {
            var members = locator.Locate(api.FindHost(host).Require());
            var idx = index(members);
            var archive =  Archives.capture(root);
            var paths =  HostCaptureArchive.create(root, host);
            var code = EncodedHexReader.Service.Read(paths.HostHexPath);
            var opIndex =  UriHexQuery.Service.CreateIndex(code);
            return ApiCodeIndex.create(idx, opIndex);
        }

        public static ApiIndex index(ApiMembers src)
        {
            var index = Identify.index(src.Storage.Select(h => (h.Id, h)),true);
            return new ApiIndex(index.HashTable, index.Duplicates);
        }
    }
}