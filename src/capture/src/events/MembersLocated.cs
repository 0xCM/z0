//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct MembersLocated : IWfEvent<MembersLocated>
    {
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;
        
        public readonly ApiMember[] Members;

        [MethodImpl(Inline)]
        public MembersLocated(ApiHostUri host, ApiMember[] functions)
        {
            Host = host;
            Members = functions;
        }
        
        public string Format()
            => $"{Members.Length} {Host} members located";

        public MembersLocated Zero 
            => Empty;            

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;            

        public static MembersLocated Empty 
            => new MembersLocated(ApiHostUri.Empty, Array.Empty<ApiMember>());
    }    
}