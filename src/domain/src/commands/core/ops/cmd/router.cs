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

    partial struct Cmd
    {
        [Op]
        public static ICmdRouter router(IWfShell wf, params CmdHandler[] handlers)
            => new CmdRouter(wf, handlers);
    }
}