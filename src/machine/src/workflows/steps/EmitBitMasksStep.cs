//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Flow;

    [Step(WfStepId.EmitBitMasks, true)]
    public readonly struct EmitBitMasksStep
    {
        public const string WorkerName = nameof(EmitBitMasks);

        public const string RunningPattern = "Emitting bitmasks to {0}";

        public const string RanPattern = "Emitted {0} bitmasks to {1}";        
    }
}