//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MembersLocated : IWfEvent<MembersLocated>
    {
        public WfEventId EventId  => WfEventId.define("Placeholder");

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

        public MessageFlair Flair 
            => MessageFlair.Cyan;            

        public static MembersLocated Empty 
            => default;
    }    
}