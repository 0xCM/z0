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

    public readonly struct ExtractedMembers : IWfEvent<ExtractedMembers>
    {            
        const string Pattern = "{0}: {1} {2}";

        public WfEventId Id {get;}

        public readonly ApiHostUri Host;

        public readonly int MemberCount;

        [MethodImpl(Inline)]
        public ExtractedMembers(ApiHostUri host, int count, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(nameof(ExtractedMembers), ct);
            Host = host;
            MemberCount = count;
        }

        public string Format()
            => text.format(Pattern, Id, MemberCount, Host.Format());

        public ExtractedMembers Zero
            => Empty;
        
        public static ExtractedMembers Empty 
            => default;
    }    
}