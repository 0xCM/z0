//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
    public struct ToolGroup
    {
        public const string TableId = "tools.groups";

        public CharBlock16 GroupName;

        public CharBlock64 Description;
    }
}