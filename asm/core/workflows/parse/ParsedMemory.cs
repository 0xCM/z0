//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct ParsedMemory
    {        
        public readonly ExtractionOutcome Outcome;

        public readonly ParsedMemoryExtract Bits;

        [MethodImpl(Inline)]
        public static ParsedMemory Define(ExtractionOutcome outcome, ParsedMemoryExtract bits)
            => new ParsedMemory(outcome, bits);

        [MethodImpl(Inline)]
        ParsedMemory(ExtractionOutcome outcome, ParsedMemoryExtract bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}