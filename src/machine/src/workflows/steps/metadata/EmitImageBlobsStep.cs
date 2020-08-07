//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Step(StepId, true)]
    public readonly struct EmitBlobsStep
    {
        public const WfStepKind StepId = WfStepKind.EmitBlobs;

        public const string StepName = nameof(EmitBlobs);        

        public const string EmissionType = "Metablobs";
    }    
}