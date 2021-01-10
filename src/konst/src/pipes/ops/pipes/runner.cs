//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Pipes
    {
        [Op]
        public static IPipeRunner runner(IWfShell wf)
            => PipeRunnerSvc.init(wf);
    }
}