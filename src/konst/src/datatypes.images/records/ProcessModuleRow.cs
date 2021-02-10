//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ProcessModuleRow : IRecord<ProcessModuleRow>
    {
        public const string TableId = "process-module";

        public MemoryAddress BaseAddress;

        public ByteSize MemorySize;

        public Name ImageName;

        public MemoryAddress EntryAddress;

        public VersionInfo Version;

        public FS.FilePath ImagePath;
    }
}