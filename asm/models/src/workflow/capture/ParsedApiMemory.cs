//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public readonly struct ParsedApiMemory
    {        
        public readonly ApiExtractResult Outcome;

        public readonly ParsedMemoryExtract Bits;

        [MethodImpl(Inline)]
        public static ParsedApiMemory Define(ApiExtractResult outcome, ParsedMemoryExtract bits)
            => new ParsedApiMemory(outcome, bits);

        [MethodImpl(Inline)]
        ParsedApiMemory(ApiExtractResult outcome, ParsedMemoryExtract bits)
        {            
            this.Outcome = outcome;
            this.Bits = bits;
        }
    }
}