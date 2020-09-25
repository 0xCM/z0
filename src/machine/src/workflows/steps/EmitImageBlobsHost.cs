//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [WfHost]
    public sealed class EmitImageBlobsHost : WfHost<EmitImageBlobsHost>
    {
        public const string EmissionType = "Metablobs";

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageBlobs(wf,this);
            step.Run();
        }
    }
}