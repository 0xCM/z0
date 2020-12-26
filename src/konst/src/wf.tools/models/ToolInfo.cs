//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct ToolInfo : IRecord<ToolInfo>
    {
        public ToolId ToolId;

        public Name ToolName;

        public ToolUsage Syntax;

        public CmdOptionSpecs Options;
    }
}