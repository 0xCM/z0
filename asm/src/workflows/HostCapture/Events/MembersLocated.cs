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
        public readonly struct MembersLocated : IAppEvent<MembersLocated, LocatedMember[]>
        {
            public static MembersLocated Empty => new MembersLocated(ApiHostUri.Empty, new LocatedMember[]{});

            [MethodImpl(Inline)]
            public static MembersLocated Define(ApiHostUri host, LocatedMember[] members)
                => new MembersLocated(host, members);

            [MethodImpl(Inline)]
            MembersLocated(ApiHostUri host, LocatedMember[] functions)
            {
                this.Host = host;
                this.EventData = functions;
            }
            
            public ApiHostUri Host {get;}
            
            public LocatedMember[] EventData {get;}

            public string Description
                => $"{EventData.Length} {Host} members located";
            
            public string Format()
                => Description;         
        }    
    }
}