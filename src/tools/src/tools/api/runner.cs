//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;
    
    using static Konst;

    partial struct Tooling
    {
        [Op]
        public static ToolRunner runner(IWfContext context, string command, ToolRunnerConfig config)
            => new ToolRunner(command, config);
    }

}