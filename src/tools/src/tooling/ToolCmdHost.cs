//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = ToolCmdKind;

    public sealed class ToolCmdHost : WfCmdHost<ToolCmdHost,ToolCmdKind>
    {
        [Action(K.UpdateToolHelpIndex)]
        void UpdateToolHelpIndex()
        {
            var catalog = Tools.catalog(Wf);
            var index = catalog.UpdateHelpIndex();
            root.iter(index, entry => Wf.Row(entry.HelpPath));
        }
    }
}