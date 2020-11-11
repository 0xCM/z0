//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public sealed class EmitToolScripts : CmdHost<EmitToolScripts, EmitToolScriptsCmd>
    {
        public static EmitToolScriptsCmd specify(IWfShell wf)
        {
            var cmd = new EmitToolScriptsCmd();
            return cmd;
        }


        protected override CmdResult Execute(IWfShell wf, in EmitToolScriptsCmd spec)
           => throw new NotSupportedException();
    }
}