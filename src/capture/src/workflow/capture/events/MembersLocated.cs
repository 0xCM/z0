//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = CaptureWorkflowEvents.MembersLocated;

    partial class CaptureWorkflowEvents
    {
        public readonly struct MembersLocated : IAppEvent<E>
        {
            public static E Empty => new E(ApiHostUri.Empty, new ApiMember[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, ApiMember[] members)
                => new E(host, members);

            [MethodImpl(Inline)]
            MembersLocated(ApiHostUri host, ApiMember[] functions)
            {
                this.Host = host;
                this.Members = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public ApiMember[] Members {get;}

            public string Description
                => $"{Members.Length} {Host} members located";

            public E Zero => Empty;            

            public AppMsgColor Flair => AppMsgColor.Cyan;            
        }    
    }
}