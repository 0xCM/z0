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
            var config = Flow.configure(args);
            using var log = Flow.log(config);
            using var wf = Flow.shell(config, log);
            using var step = new XedWf(wf, new XedEtlConfig(wf, config.Settings));
            step.Run();
        }
    }
}