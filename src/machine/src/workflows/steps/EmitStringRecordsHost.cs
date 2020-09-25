//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static RP;

    [WfHost]
    public sealed class EmitStringRecordsHost : WfHost<EmitStringRecordsHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitStringRecords(wf,this);
            step.Run();
        }

        public const string DataType = "strings";

        public const string UserKind = nameof(PartStringKind.User);

        public const string SystemKind = nameof(PartStringKind.System);

        public const string TargetFolder = DataType + Plural;

        public const string UserTargetFolder = "strings.user";

        public const string SystemTargetFolder = "strings.system";

        public const string DataTypeExt = DataType + ExtSep + DataExt;

        public const string UserKindExt = UserKind + ExtSep + DataTypeExt;

        public const string SystemKindExt = SystemKind + ExtSep + DataTypeExt;
    }

}