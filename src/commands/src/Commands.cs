//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Threading.Tasks;

    using static Part;

    public readonly struct Commands
    {
        readonly IWfShell Wf;

        readonly CmdBuilder CmdBuilder;

        Commands(IWfShell wf)
        {
            Wf = wf;
            CmdBuilder = wf.CmdBuilder();
        }
    }
}