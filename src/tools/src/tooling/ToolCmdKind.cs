//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [WfCmdKind]
    public enum ToolCmdKind : byte
    {
        None = 0,

        [Alias("update-help-index")]
        UpdateToolHelpIndex,
    }
}