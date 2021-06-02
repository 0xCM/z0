//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Text;

    partial class XFs
    {
        [Op]
        public static StreamWriter Writer(this FS.FilePath dst, bool append)
            => FS.writer(dst, append ? FileWriteMode.Append : FileWriteMode.Overwrite);

        [Op]
        public static StreamWriter Writer(this FS.FilePath dst, bool append, Encoding encoding)
            => FS.writer(dst, append ? FileWriteMode.Append : FileWriteMode.Overwrite, encoding);

        [Op]
        public static StreamWriter Writer(this FS.FilePath dst)
            => FS.writer(dst);

        [Op]
        public static StreamWriter Writer(this FS.FilePath dst, Encoding encoding)
            => FS.writer(dst, encoding);

        [Op]
        public static StreamWriter Writer(this FS.FilePath dst, FileWriteMode mode)
            => FS.writer(dst,mode);

        [Op]
        public static StreamWriter Writer(this FS.FilePath dst, FileWriteMode mode, Encoding encoding)
            => FS.writer(dst,mode,encoding);

        [Op]
        public static void AppendLines(this FS.FilePath dst, string src)
            => File.AppendAllLines(dst.EnsureParentExists().Name, core.array(src));

        [Op]
        public static void AppendLines(this FS.FilePath dst, string src, Encoding encoding)
            => File.AppendAllLines(dst.EnsureParentExists().Name, core.array(src), encoding);
    }
}