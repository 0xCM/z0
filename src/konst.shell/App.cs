//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    readonly struct App
    {
        public static int Main(params string[] args)
        {
            using var wf = Flow.shell(args);
            using var runner = new WfRunner(wf);
            runner.Run();
            return 0;
        }
    }
}