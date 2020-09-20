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

    [WfHost]
    public sealed class CheckBitMasksHost : WfHost<CheckBitMasksHost>
    {
        public static void control(IWfShell wf, IPolyrand source)
        {
            var log = text.build();
            var host  = new CheckBitMasksHost();
            using var step = new CheckBitMasks(wf, host, source, log);
            step.Run();
        }
    }
}