//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public readonly struct ParsedMemory
    {        
        public readonly ExtractResult Outcome;

        public readonly ParsedMemoryExtract Bits;

        [MethodImpl(Inline)]
        public static ParsedMemory Define(ExtractResult outcome, ParsedMemoryExtract bits)
            => new ParsedMemory(outcome, bits);

        [MethodImpl(Inline)]
        ParsedMemory(ExtractResult outcome, ParsedMemoryExtract bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}