//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    
    using static Konst;
    using static z;

    [Table]
    public struct FileDescription
    {
        public FS.FilePath Path;

        public ByteSize Size;

        public Timestamp CreateTS;        

        public Timestamp UpdateTS;        

        public FileAttributes Attributes;
    }
}