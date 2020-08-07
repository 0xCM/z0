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

    public readonly struct MembersExtracted : IWfEvent<MembersExtracted>
    {
        public WfEventId EventId  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;
        
        public readonly ExtractedCode[] Members;

        [MethodImpl(Inline)]
        public MembersExtracted(ApiHostUri host, ExtractedCode[] members)
        {
            Host = host;
            Members = members;
        }
        
        public string Format()
            => $"{Members.Length} {Host} members extracted";

        public static MembersExtracted Empty 
            => new MembersExtracted(ApiHostUri.Empty, Array.Empty<ExtractedCode>());
    }    
}