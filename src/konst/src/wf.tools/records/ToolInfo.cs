//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ToolInfo
    {
        public ToolId ToolId;

        public Name ToolName;

        public UsageSyntax Syntax;

        public CmdOptionSpecs Options;
    }
}