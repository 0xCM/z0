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

    readonly struct ApiCorrelator : IApiCorrelator
    {
        public IApiContext Context {get;}

        [MethodImpl(Inline)]
        public static IApiCorrelator Create(IApiContext context)
            => new ApiCorrelator(context);
        
        [MethodImpl(Inline)]
        ApiCorrelator(IApiContext context)
        {
            this.Context = context;
        }
        
        IEnumerable<ApiMember> HostedMembers(ApiHost host)
            => Context.MemberLocator().Hosted(host);

        ApiHost FindHost(in ApiHostUri uri)
            => Context.FindHost(uri).Require();

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public IEnumerable<ApiMember> FindHostedMembers(in ApiHostUri host)
            => HostedMembers(FindHost(host));

        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public ReadOnlySpan<AsmOpBits> LoadCode(FilePath src)
            => Context.HexReader().Read(src).ToArray();

        public ApiCodeIndex CreateApiIndex(ApiHostUri host, FilePath src)
        {
            var loaded = LoadCode(src);
            var hosted = FindHostedMembers(host).ToArray();
            
            var code = loaded.ToEnumerable().ToOpIndex();
            var members = hosted.ToOpIndex();

            return CreateApiIndex(members, code);
        }

        public ApiCodeIndex CreateApiIndex(OpIndex<ApiMember> members, OpIndex<AsmOpBits> code)
        {
            var apicode = from pair in members.Intersect(code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select ApiMemberCode.Define(r.left, r.right.Bits);                                      
            return ApiCodeIndex.Create(apicode.Select(c => (c.Id, c)).ToOpIndex());
        }
    }
}