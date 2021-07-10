//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static core;

    public class ToolCatalog : AppService<ToolCatalog>
    {
        protected override void OnInit()
        {
        }

        public void Emit(CmdScript script)
        {
            var dst = ToolCmd.enqueue(ToolCmd.job(script.Id, script), Wf.Db());
            var flow = Wf.EmittingFile(dst);
            Wf.EmittedFile(flow, script.Length);
        }
    }
}