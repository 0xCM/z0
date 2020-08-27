//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        [Table]
        public struct EntryDetail : ITable<EntryDetail>
        {
            public FS.FilePath Path;

            public ByteSize Size;

            public Timestamp CreateTS;

            public Timestamp UpdateTS;

            public FileAttributes Attributes;
        }
    }
}