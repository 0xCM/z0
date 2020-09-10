//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Xed;

    readonly struct Shell
    {
        public static void Main(params string[] args)
        {
            var init = Flow.init(args);
            using var wf = Flow.shell(init);
            using var step = new XedWf(wf, new XedEtlConfig(wf, init.Settings));
            step.Run();
        }
    }
}