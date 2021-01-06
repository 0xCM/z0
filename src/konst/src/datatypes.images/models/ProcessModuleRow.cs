//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct ProcessModuleRow : IRecord<ProcessModuleRow>
    {
        public MemoryAddress BaseAddress;

        public ByteSize MemorySize;

        public Name ImageName;

        public MemoryAddress EntryAddress;

        public VersionId Version;

        public FS.FilePath ImagePath;
    }
}