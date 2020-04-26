//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public readonly struct OperationCapture
    {        
        public readonly OpIdentity Id;

        public readonly CaptureOutcome Outcome;

        public readonly ParsedMemoryExtract Data;

        [MethodImpl(Inline)]
        public static OperationCapture Define(OpIdentity id, CaptureOutcome outcome, ParsedMemoryExtract bits)
            => new OperationCapture(id, outcome, bits);

        [MethodImpl(Inline)]
        OperationCapture(OpIdentity id,  CaptureOutcome outcome, ParsedMemoryExtract bits)
        {            
            Id = id;
            Outcome = outcome;
            Data = bits;
        }
    }
}