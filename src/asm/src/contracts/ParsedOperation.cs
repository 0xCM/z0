//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsedOperation
    {        
        public readonly BinaryCode Encoded;

        public readonly OpIdentity Id;

        public readonly CaptureOutcome Outcome;

        [MethodImpl(Inline)]
        public ParsedOperation(OpIdentity id, CaptureOutcome info, byte[] content)
        {
            Id = id;
            Outcome = info;
            Encoded = content;
        }        
    }
}