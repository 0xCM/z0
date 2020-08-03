//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Step(WfStepId.EmitPartStrings, true)]
    public readonly struct EmitPartStringsStep
    {
        public const string WorkerName = nameof(EmitPartStrings);

        public const string DataType = EmitStringRecordsStep.DataType;
    }
}