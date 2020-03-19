//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class HostCaptureWorkflow
    {
        public readonly struct MembersLocated : IAppEvent<MembersLocated, ApiLocatedMember[]>
        {
            public static MembersLocated Empty => new MembersLocated(ApiHostUri.Empty, new ApiLocatedMember[]{});

            [MethodImpl(Inline)]
            public static MembersLocated Define(ApiHostUri host, ApiLocatedMember[] members)
                => new MembersLocated(host, members);

            [MethodImpl(Inline)]
            MembersLocated(ApiHostUri host, ApiLocatedMember[] functions)
            {
                this.Host = host;
                this.EventData = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public ApiLocatedMember[] EventData {get;}

            public string Description
                => $"{EventData.Length} {Host} members located";
            
            public string Format()
                => Description;         
        }    
    }
}