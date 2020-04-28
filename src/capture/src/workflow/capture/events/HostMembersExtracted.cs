//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using E = CaptureWorkflowEvents.HostMembersExtracted;

    partial class CaptureWorkflowEvents
    {
        public readonly struct HostMembersExtracted : IAppEvent<E>
        {
            public static E Empty => new E(ApiHostUri.Empty, new MemberExtract[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, MemberExtract[] members)
                => new E(host, members);

            [MethodImpl(Inline)]
            HostMembersExtracted(ApiHostUri host, MemberExtract[] extracted)
            {
                this.Host = host;
                this.Extracts = extracted;
            }
            
            public ApiHostUri Host {get;}
            
            public MemberExtract[] Extracts {get;}

            public string Description
                => $"{Extracts.Length} {Host} members extracted";

            public E Zero => Empty; 
        }    
    }
}