//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    using static z;
    
    [Step(WfStepKind.EmitCilDatasets,true)]
    public readonly struct EmitCilDatasetsStep
    {
        public const string WorkerName = nameof(EmitCilDatasets);
        
        public const string DatasetName = "Cil";

        public const string Completed = IdMarker + "Emitted {1} total Cil records";

        public const string Emitting = IdMarker + "Emitting Cil dataset for {1} to {2}";

        public const string Emitted = IdMarker + "Emitted {1} {2} Cil records";

        public const string DataType = "il";

        public const string DataFolder = DataType;

        public const string DatasetExt = DataType + ExtPartSep +  DataFileExt;
    }
}