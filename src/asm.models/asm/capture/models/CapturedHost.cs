//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    /// <summary>
    /// Aggregates artifacts from a host capture workflow
    /// </summary>
    public readonly struct CapturedHost
    {
        public readonly ApiHostUri Host;

        public readonly ExtractedCode[] Extracts;

        public readonly ParsedExtraction[] Parsed;
        
        public readonly AsmFunction[] Decoded;
        
        [MethodImpl(Inline)]
        public CapturedHost(ApiHostUri host, ExtractedCode[] extracts, ParsedExtraction[] parsed, AsmFunction[] decoded)
        {
            Host = host;
            Extracts = extracts;
            Parsed = parsed;
            Decoded = decoded;
        }
    }
}