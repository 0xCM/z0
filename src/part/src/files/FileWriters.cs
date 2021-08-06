//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Root;

    public readonly struct FileWriters
    {
        public static StreamWriter writer(FS.FilePath dst, FileWriteMode mode, Encoding encoding)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), mode == FileWriteMode.Append, encoding);

        public static StreamWriter asci(FS.FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), mode == FileWriteMode.Append, Encoding.ASCII);

        public static StreamWriter utf8(FS.FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), mode == FileWriteMode.Append, Encoding.UTF8);

        public static StreamWriter unicode(FS.FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), mode == FileWriteMode.Append, Encoding.Unicode);
    }
}