//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial class XWf
    {
        public static IEnumerable<ICmdExecSpec> FindCommands(this IWfShell wf)
        {
            foreach(var a in wf.Components)
            {
                foreach(var c in Cmd.search(a))
                {
                    yield return c;
                }
            }
        }
    }
}