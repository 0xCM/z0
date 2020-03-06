//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct MemoryParseSummary
    {        
        public readonly ExtractionOutcome Outcome;

        public readonly ParsedMemoryExtract Bits;

        [MethodImpl(Inline)]
        public static MemoryParseSummary Define(ExtractionOutcome outcome, ParsedMemoryExtract bits)
            => new MemoryParseSummary(outcome, bits);

        [MethodImpl(Inline)]
        MemoryParseSummary(ExtractionOutcome outcome, ParsedMemoryExtract bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}