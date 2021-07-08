//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
    public struct ToolMembership : IRecord<ToolMembership>
    {
        public const string TableId = "tools.group-members";

        public ToolId Tool;

        public CharBlock16 GroupName;
    }
}