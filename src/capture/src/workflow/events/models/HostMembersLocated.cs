//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using E = AsmEvents.HostMembersLocated;

    partial class AsmEvents
    {
        public readonly struct HostMembersLocated : IAppEvent<E, ApiMember[]>
        {
            public static E Empty => new E(ApiHostUri.Empty, new ApiMember[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, ApiMember[] members)
                => new E(host, members);

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

            public E Zero => Empty;            

            public AppMsgColor Flair => AppMsgColor.Cyan;            
        }    
    }
}