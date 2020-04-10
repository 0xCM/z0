//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AsmEvents.HostMembersExtracted;

    partial class AsmEvents
    {
        public readonly struct HostMembersExtracted : IAppEvent<E, MemberExtract[]>
        {
            public static E Empty => new E(ApiHostUri.Empty, new MemberExtract[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, MemberExtract[] members)
                => new E(host, members);

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

            public E Zero => Empty; 
        }    
    }
}