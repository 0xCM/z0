//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Entity, StructLayout(LayoutKind.Sequential)]
    public struct ToolInfo
    {
        public Name Name;

        public CmdHostId ToolId;

        public UsageSyntax Usage;

        public CmdOptionSpecs Options;

        public ToolVerb[] Verbs;
    }
}