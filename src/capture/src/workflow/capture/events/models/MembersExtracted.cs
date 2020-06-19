//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct MembersExtracted : IAppEvent<MembersExtracted>
    {
        public readonly ApiHostUri Host;
        
        public readonly ExtractedMember[] Members;

        [MethodImpl(Inline)]
        public MembersExtracted(ApiHostUri host, ExtractedMember[] members)
        {
            Host = host;
            Members = members;
        }
        
        public string Description
            => $"{Members.Length} {Host} members extracted";

        public MembersExtracted Zero 
            => Empty; 

        public static MembersExtracted Empty 
            => new MembersExtracted(ApiHostUri.Empty, Array.Empty<ExtractedMember>());
    }    
}