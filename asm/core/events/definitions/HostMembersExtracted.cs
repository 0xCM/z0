//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct HostMembersExtracted : IAppEvent<HostMembersExtracted, MemberExtract[]>
    {
        public static HostMembersExtracted Empty => new HostMembersExtracted(ApiHostUri.Empty, new MemberExtract[]{});

        [MethodImpl(Inline)]
        public static HostMembersExtracted Define(ApiHostUri host, MemberExtract[] members)
            => new HostMembersExtracted(host, members);

        [MethodImpl(Inline)]
        HostMembersExtracted(ApiHostUri host, MemberExtract[] extracted)
        {
            this.Host = host;
            this.Payload = extracted;
        }
        
        public ApiHostUri Host {get;}
        
        public MemberExtract[] Payload {get;}

        public string Description
            => $"{Payload.Length} {Host} members extracted";
        
        public string Format()
            => Description;         
    }    

}