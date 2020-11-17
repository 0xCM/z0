//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Entity, StructLayout(LayoutKind.Sequential)]
    public struct ToolModel
    {
        public Name Name;

        public ToolId ToolId;

        public UsageSyntax Usage;

        public ToolOptions Options;

        public OptionDelimiter Delimiter;
    }
}