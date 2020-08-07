//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Flow;

    [Step(WfStepKind.EmitPeImage, true)]
    public readonly struct EmitPeImageStep
    {
        public const string WorkerName = nameof(EmitPeImage);        

        public const string DataType = "hexline";

        public const string DatasetName = "PeImage";
    }
}