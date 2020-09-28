//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [Op]
        public static ToolProcess runner(IWfShell context, string command, ToolProcessOptions config)
            => new ToolProcess(command, config);
    }
}