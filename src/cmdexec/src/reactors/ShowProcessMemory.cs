//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class ShowProcessMemory : CmdReactor<ShowProcessMemoryCmd>
    {
        protected override CmdResult Run(ShowProcessMemoryCmd cmd)
        {
            var map = Runtime.map(Runtime.CurrentProcess);
            Wf.Row(string.Format("Name:{0}", map.ProcessName));
            Wf.Row(string.Format("Base:{0}", map.BaseAddress));
            Wf.Row(string.Format("Size:{0}", map.MemorySize));
            Wf.Row("Modules");
            Wf.Row(RP.PageBreak120);
            root.iter(map.Modules, m => Wf.Row(m.Format()));
            return Cmd.ok(cmd);
        }
    }
}
