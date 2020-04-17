//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public readonly struct MemoryParseResult
    {        
        public readonly ApiExtractResult Outcome;

        public readonly ParsedMemoryExtract Bits;

        [MethodImpl(Inline)]
        public static MemoryParseResult Define(ApiExtractResult outcome, ParsedMemoryExtract bits)
            => new MemoryParseResult(outcome, bits);

        [MethodImpl(Inline)]
        MemoryParseResult(ApiExtractResult outcome, ParsedMemoryExtract bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}