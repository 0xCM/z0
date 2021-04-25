//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiCaptureResult
    {
        public CaptureOutcome Outcome {get;}

        public CodeBlockPair Pair {get;}

        [MethodImpl(Inline)]
        internal ApiCaptureResult(CaptureOutcome outcome, CodeBlockPair pair)
        {
            Outcome = outcome;
            Pair = pair;
        }
    }
}