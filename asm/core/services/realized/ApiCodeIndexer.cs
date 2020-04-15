//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct ApiCodeIndexer : IApiCodeIndexer
    {
        readonly IContext Context;

        readonly IApiSet ApiSet;

        readonly IMemberLocator MemberLocator;
        
        [MethodImpl(Inline)]
        public static IApiCodeIndexer Create(IContext context, IApiSet api)
            =>  new ApiCodeIndexer(context, api);
        
        [MethodImpl(Inline)]
        ApiCodeIndexer(IContext context, IApiSet api)
        {
            this.Context = context;
            this.ApiSet = api;
            this.MemberLocator = context.MemberLocator();
        }
        
        ApiMembers HostedMembers(IApiHost host)
            => MemberLocator.Hosted(host);

        IApiHost FindHost(in ApiHostUri uri)
            => ApiSet.FindHost(uri).Require();

        IEnumerable<ApiMember> FindHostedMembers(in ApiHostUri host)
            => HostedMembers(FindHost(host));

        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public ReadOnlySpan<AsmOpBits> LoadCode(FilePath src)
            => Context.HexReader().Read(src).ToArray();

        public ApiCodeIndex CreateIndex(ApiHostUri host, FilePath src)
        {
            var loaded = LoadCode(src);
            var hosted = FindHostedMembers(host).ToArray();
            
            var code = loaded.ToEnumerable().ToOpIndex();
            var members = ApiIndex.From(hosted);

            return CreateIndex(members, code);
        }

        public ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<AsmOpBits> code)
        {
            var apicode = from pair in members.Intersect(code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select ApiMemberCode.Define(r.left, r.right.Bits);                                      
            return ApiCodeIndex.Create(apicode.Select(c => (c.Id, c)).ToOpIndex());
        }
    }
}