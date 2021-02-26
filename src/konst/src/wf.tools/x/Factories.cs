//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Part;

    partial class XWf
    {
        public static ToolScriptRunner ScriptRunner(this IWfShell wf)
            => ToolScriptRunner.create(wf);
    }
}