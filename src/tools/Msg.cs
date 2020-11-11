//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    readonly struct Msg
    {
        public static RenderPattern<ToolId> ToolHelpNotFound => "Tool {0} help not found";
    }
}