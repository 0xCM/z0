//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class EmitPartStrings : WfHost<EmitPartStrings>
    {
        public const string EmissionType = ImageStringRecords.DataType;

        public static WfStepId StepId
            => Flow.step<EmitPartStrings>();

        public static string ExtName(PartStringKind kind)
            => (kind == PartStringKind.System ? ImageStringRecords.SystemKindExt : ImageStringRecords.UserKindExt).ToLower();
    }
}