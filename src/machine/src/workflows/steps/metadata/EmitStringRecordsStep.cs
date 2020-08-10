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

    [Step(WfStepKind.EmitPartStrings, true)]
    public readonly struct EmitStringRecordsStep
    {
        public const string ActorName = nameof(EmitStringRecords);

        public const WfStepKind Kind = WfStepKind.EmitPartStrings;

        public const string DataType = "metastring";

        public const string UserKind = "user";

        public const string SystemKind = "system";

        public const string TargetFolder = DataType + Plural;

        public const string DataTypeExt = DataType + ExtPartSep + DataFileExt;

        public const string UserKindExt = SystemKind + ExtPartSep + DataTypeExt;

        public const string SystemKindExt = UserKind + ExtPartSep + DataTypeExt;
    }
}