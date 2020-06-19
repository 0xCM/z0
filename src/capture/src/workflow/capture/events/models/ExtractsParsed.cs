//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using E = ExtractsParsed;

    public readonly struct ExtractsParsed : IAppEvent<E>
    {   
        public readonly ApiHostUri Host;
        
        public readonly ParsedMember[] Members;

        [MethodImpl(Inline)]
        public ExtractsParsed(ApiHostUri host, ParsedMember[] members)
        {
            Host = host;
            Members = members;
        }
        
        public string Description
            => $"{Members.Length} {Host} members parsed";
        
        public ExtractsParsed Zero 
            => Empty;

        public static ExtractsParsed Empty 
            => new ExtractsParsed(ApiHostUri.Empty, Array.Empty<ParsedMember>());
    }    
}