//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    readonly struct App
    {
        public static int Main(params string[] args)
        {
            var wf = WfBuilder.shell(Assembly.GetEntryAssembly(), args, out var app);
            return Run(wf);
        }

        public int Run(IWfShell wf)
        {

            return 0;
        }
    }
}