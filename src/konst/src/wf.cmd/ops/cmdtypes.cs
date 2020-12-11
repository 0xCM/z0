//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Cmd
    {
        [Op]
        public static CmdTypeInfo[] cmdtypes(IWfShell wf)
            => wf.Components.Types().Tagged<CmdAttribute>().Select(cmdtype);
    }
}