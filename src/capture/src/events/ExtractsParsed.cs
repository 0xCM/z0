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

    using E = ExtractsParsed;

    public readonly struct ExtractsParsed : IWfEvent<E>
    {   
        public WfEventId EventId  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;
        
        public readonly ParsedExtraction[] Members;

        [MethodImpl(Inline)]
        public ExtractsParsed(ApiHostUri host, ParsedExtraction[] members)
        {
            Host = host;
            Members = members;
        }
        
        public string Format()
            => $"{Members.Length} {Host} members parsed";
        
        public static ExtractsParsed Empty 
            => default;
    }    
}