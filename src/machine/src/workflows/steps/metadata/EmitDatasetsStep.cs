//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Flow;
    using System.Runtime.CompilerServices;

    public readonly struct EmitDatasetsStep
    {
        public const string WorkerName = nameof(EmitDatasets);

        public const WfStepKind Kind = WfStepKind.EmitDatasets;

        public static WfStepId Id([CallerFilePath] string caller = null) => new WfStepId(typeof(EmitDatasets), caller);
    }
}