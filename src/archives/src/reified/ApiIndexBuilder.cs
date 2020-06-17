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

    readonly struct ApiIndexBuilder : IApiIndexBuilder
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
            var code = UriHexReader.Service.Read(src).ToArray();
            var host = ApiSet.FindHost(uri).Require();
            var members = Locator.Hosted(host);
            var codeIndex =  UriHexQuery.Service.CreateIndex(code);
            var memberIndex = ApiIndex.Create(members);
            return CreateIndex(memberIndex, codeIndex);
        }

        public ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<UriHex> code)
        {
            var apicode = from pair in members.Intersect(code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select ApiMemberCode.Define(r.left, r.right);                                      
            return ApiCodeIndex.Create(apicode.Select(c => (c.Id, c)).ToOpIndex());
        }
    }
}