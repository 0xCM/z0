//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.IO;

    partial struct FS
    {
        [Record(TableId)]
        public struct FsEntryDetail
        {
            public const string TableId = "fs.entry";

            public FS.FilePath Path;

            public ByteSize Size;

            public Timestamp CreateTS;

            public Timestamp UpdateTS;

            public FileAttributes Attributes;
        }
    }
}