//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiParseResult
    {
        public readonly OpIdentity Id;

        public readonly CodeBlockDataFlow DataFlow;

        public readonly CaptureOutcome Outcome;

        [MethodImpl(Inline)]
        public ApiParseResult(OpIdentity id, CaptureOutcome info, CodeBlockDataFlow encoded)
        {
            Id = id;
            Outcome = info;
            DataFlow = encoded;
        }
    }
}