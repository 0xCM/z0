//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Step(WfStepId.EmitPeHeaders)]
    public readonly struct EmitPeHeadersStep
    {
        public const string WorkerName = nameof(EmitPeHeaders);
    }
}