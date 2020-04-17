//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Aggregates artifacts obtained via host capture workflow execution
    /// </summary>
    public readonly struct ApiHostCapture
    {
        public readonly ApiHostUri Host;

        public readonly ExtractedMember[] Extracts;

        public readonly ParsedExtract[] Parsed;
        
        public readonly AsmFunction[] Decoded;

        [MethodImpl(Inline)]
        public static ApiHostCapture Define(ApiHostUri host, ExtractedMember[] extracts, ParsedExtract[] parsed, AsmFunction[] decoded)
            => new ApiHostCapture(host, extracts, parsed, decoded);
        
        [MethodImpl(Inline)]
        ApiHostCapture(ApiHostUri host, ExtractedMember[] extracts, ParsedExtract[] parsed, AsmFunction[] decoded)
        {
            this.Host = host;
            this.Extracts = extracts;
            this.Parsed = parsed;
            this.Decoded = decoded;
        }

    }
}