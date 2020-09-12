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

        public static ApiCodeIndex index(IMemberLocator locator, ApiSet api, ApiHostUri uri, FilePath src)
        {
            var code = X86UriHexReader.Service.Read(src).ToArray();
            var host = api.FindHost(uri).Require();
            var members = locator.Locate(host);
            var codeIndex =  X86UriHexQuery.Service.CreateIndex(code);
            var memberIndex = index(members);
            return ApiCodeIndex.create(memberIndex, codeIndex);
        }

        public static ApiCodeIndex index(IMemberLocator locator, ApiSet api, ApiHostUri host, FolderPath root)
        {
            var members = locator.Locate(api.FindHost(host).Require());
            var idx = index(members);
            var archive =  Archives.capture(root);
            var paths =  HostCaptureArchive.create(root, host);
            var code = X86UriHexReader.Service.Read(paths.HostX86Path);
            var opIndex =  X86UriHexQuery.Service.CreateIndex(code);
            return ApiCodeIndex.create(idx, opIndex);
        }

        public static ApiMemberIndex index(ApiMembers src)
        {
            var index = Identify.index(src.Storage.Select(h => (h.Id, h)),true);
            return new ApiMemberIndex(index.HashTable, index.Duplicates);
        }
    }
}