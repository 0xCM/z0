//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId,FieldCount)]
    public struct FsEntryDetail
    {
        public const string TableId = "fs.entry";

        public const byte FieldCount = 5;

        public FS.FilePath Path;

        public ByteSize Size;

        public Timestamp CreateTS;

        public Timestamp UpdateTS;

        public FileAttributes Attributes;
    }
}