//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;

    [WfHost]
    public sealed class EmitImageDataHost : WfHost<EmitImageDataHost>
    {
        IPart Part;

        public static EmitImageDataHost create(IPart part)
        {
            var host = new EmitImageDataHost();
            host.Part = part;
            return host;
        }

        public ref EmitImageData Step(IWfShell wf, out EmitImageData step)
        {
            step = new EmitImageData(wf, this, Part);
            return ref step;
        }
    }
}