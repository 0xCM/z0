//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct ToolInfo : IRecord<ToolInfo>
    {
        public const string TableId = "tools.info";

        public ToolId ToolId;

        public CharBlock64 Descripion;

        public CharBlock16 GroupName;

        public FS.FilePath PhysicalPath;

        public FS.FilePath VirtualPath;

        public FS.FilePath ShimPath;
    }
}