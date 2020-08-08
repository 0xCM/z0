//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    [Step(WfStepKind.EmitFieldMetadata, true)]
    public readonly struct EmitFieldMetadataStep
    {
        public const string WorkerName = nameof(EmitFieldMetadata);

        public const string DataType = "FieldMetadata";

        public const string DatasetName = "FieldMetadata";
    }
}