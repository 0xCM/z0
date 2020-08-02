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

    public readonly struct ExtractsParsed : IWfEvent<E>
    {   
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;
        
        public readonly ParsedExtract[] Members;

        [MethodImpl(Inline)]
        public ExtractsParsed(ApiHostUri host, ParsedExtract[] members)
        {
            Host = host;
            Members = members;
        }
        
        public string Format()
            => $"{Members.Length} {Host} members parsed";
        
        public ExtractsParsed Zero 
            => Empty;

        public static ExtractsParsed Empty 
            => new ExtractsParsed(ApiHostUri.Empty, Array.Empty<ParsedExtract>());
    }    
}