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

    using static Root;

    readonly struct ApiCorrelator : IApiCorrelator
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IApiCorrelator Create(IAsmContext context)
            => new ApiCorrelator(context);
        
        [MethodImpl(Inline)]
        ApiCorrelator(IAsmContext context)
        {
            this.Context = context;
        }
        
        IEnumerable<HostedMember> HostedMembers(ApiHost host)
            => Context.MemberLocator().Hosted(host);

        ApiHost FindHost(in ApiHostUri uri)
            => Context.FindHost(uri).Require();

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public IEnumerable<HostedMember> FindHostedMembers(in ApiHostUri host)
            => HostedMembers(FindHost(host));

        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public ReadOnlySpan<AsmOpBits> LoadCode(FilePath src)
            => Context.HexReader().Read(src).ToArray();

        public OpIndex<ApiMemberCode> IndexMemberCode(ApiHostUri host, FilePath src)
        {
            var loaded = LoadCode(src);
            var hosted = FindHostedMembers(host).ToArray();
            
            var codeidx = loaded.ToEnumerable().ToOpIndex();
            var hostedidx = hosted.ToOpIndex();

            var apicode = from pair in hostedidx.Intersect(codeidx).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select ApiMemberCode.Define(r.left, r.right.Bits);                                      
            return apicode.Select(c => (c.Id, c)).ToOpIndex();
        }
    }
}