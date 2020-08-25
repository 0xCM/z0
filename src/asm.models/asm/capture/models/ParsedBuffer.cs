//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsedBuffer
    {
        public readonly OpIdentity Id;

        public readonly ParsedEncoding Encoded;

        public readonly CaptureOutcome Outcome;

        [MethodImpl(Inline)]
        public ParsedBuffer(OpIdentity id, CaptureOutcome info, ParsedEncoding encoded)
        {
            Id = id;
            Outcome = info;
            Encoded = encoded;
        }
    }
}