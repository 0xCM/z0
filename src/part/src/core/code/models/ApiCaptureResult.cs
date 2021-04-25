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
        public readonly OpIdentity Id;

        public readonly CapturedCodeBlock Code;

        public readonly CaptureOutcome Outcome;

        [MethodImpl(Inline)]
        public ApiCaptureResult(OpIdentity id, CaptureOutcome info, CapturedCodeBlock encoded)
        {
            Id = id;
            Outcome = info;
            Code = encoded;
        }
    }
}