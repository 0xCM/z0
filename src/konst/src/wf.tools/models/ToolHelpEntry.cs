//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ToolHelpEntry : IRecord<ToolHelpEntry>
    {
        public const string TableId = "toolhelp";

        public ToolId Tool;

        public FS.FileUri HelpPath;
    }
}