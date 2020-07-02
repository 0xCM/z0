//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExtractedMembers : IAppEvent<ExtractedMembers>
    {            
        public readonly ApiHostUri Host;

        public readonly int MemberCount;

        [MethodImpl(Inline)]
        public ExtractedMembers(ApiHostUri host, int count)
        {
            Host = host;
            MemberCount = count;
        }

        public string Description
            => $"{MemberCount} {Host.Format()} members extracted";

        public ExtractedMembers Zero
            => Empty;
        
        public static ExtractedMembers Empty 
            => default;
    }    
}