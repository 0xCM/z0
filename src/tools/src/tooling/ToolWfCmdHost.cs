//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WfCmd;

    using K = ToolWfCmdKind;

    public enum ToolWfCmdKind : byte
    {
        None = 0,

        UpdateToolHelpIndex,
    }

    public sealed class ToolWfCmdHost : WfCmdHost<ToolWfCmdHost, ToolWfCmdKind>
    {
        protected override void RegisterCommands(WfCmdIndex index)
        {
            index.Include(assign(K.UpdateToolHelpIndex, UpdateToolHelpIndex));
        }

        [Action(K.UpdateToolHelpIndex)]
        public void UpdateToolHelpIndex()
        {
            var catalog = Tools.catalog(Wf);
            var index = catalog.UpdateHelpIndex();
            root.iter(index, entry => Wf.Row(entry.HelpPath));
        }
    }
}