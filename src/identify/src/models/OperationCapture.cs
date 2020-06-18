//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct OperationCapture : IIdentified<OpIdentity>
    {        
        public OpIdentity Id {get;}

        public readonly CaptureOutcome Outcome;

        public readonly ParsedCode Data;

        [MethodImpl(Inline)]
        public OperationCapture(OpIdentity id,  CaptureOutcome outcome, ParsedCode code)
        {            
            Id = id;
            Outcome = outcome;
            Data = code;
        }
    }
}