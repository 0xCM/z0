//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct ProcessModuleRow : IRecord<ProcessModuleRow>
    {
        public MemoryAddress Base;

        public MemoryAddress Entry;

        public ByteSize Size;

        public utf8 Name;

        public FS.FilePath Path;

        public VersionId Version;
    }
}