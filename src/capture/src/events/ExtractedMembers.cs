//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FormatPatterns;

    public readonly struct ExtractedMembers : IWfEvent<ExtractedMembers>
    {            
        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        public readonly int MemberCount;

        [MethodImpl(Inline)]
        public ExtractedMembers(ApiHostUri host, int count, CorrelationToken? ct = null)
        {
            EventId = WfEventId.define(nameof(ExtractedMembers), ct);
            Host = host;
            MemberCount = count;
        }

        public string Format()
            => text.format(PSx3, EventId, MemberCount, Host.Format());

        public ExtractedMembers Zero
            => Empty;
        
        public static ExtractedMembers Empty 
            => default;
    }    
}