//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Flow;

    [Step(Kind, true)]
    public readonly struct EmitBitMasksStep
    {
        public const WfStepKind Kind = WfStepKind.EmitBitMasks;
        
        public const string Name = nameof(EmitBitMasks);
        
        public const string RunningPattern = "Emitting bitmasks to {0}";

        public const string RanPattern = "Emitted {0} bitmasks to {1}";        
    }
}