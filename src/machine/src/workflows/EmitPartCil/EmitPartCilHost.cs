//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static RP;

    [Step]
    public sealed class EmitPartCilHost : WfHost<EmitPartCilHost>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitPartCil(wf, this);
            step.Run();
        }

        public const string DatasetName = "Cil";

        public const string EmissionType = "il";

        public const string DataFolder = EmissionType;

        public const string DatasetExt = EmissionType + ExtSep +  DataExt;
    }

}