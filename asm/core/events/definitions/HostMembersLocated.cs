//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct HostMembersLocated : IAppEvent<HostMembersLocated, ApiMember[]>
    {
        public static HostMembersLocated Empty => new HostMembersLocated(ApiHostUri.Empty, new ApiMember[]{});

        [MethodImpl(Inline)]
        public static HostMembersLocated Define(ApiHostUri host, ApiMember[] members)
            => new HostMembersLocated(host, members);

        [MethodImpl(Inline)]
        HostMembersLocated(ApiHostUri host, ApiMember[] functions)
        {
            this.Host = host;
            this.Payload = functions;
        }
        
        public ApiHostUri Host {get;}
        
        public ApiMember[] Payload {get;}

        public string Description
            => $"{Payload.Length} {Host} members located";
        
        public string Format()
            => Description;         
    }    
}