//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.IO;

    [Record(TableId)]
    public struct FsEntryRecord : IRecord<FsEntryRecord>
    {
        public const string TableId = "fs.entry";

        public FS.FilePath Path;

        public ByteSize Size;

        public Timestamp CreateTS;

        public Timestamp UpdateTS;

        public FileAttributes Attributes;
    }
}