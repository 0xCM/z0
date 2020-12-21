//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XFs
    {
        public static string SearchPattern(params FS.FileExt[] src)
            => text.join(";*.", src.Select(e => e.Name));

        public static StreamWriter Writer(this FS.FilePath dst, bool append)
            => FS.writer(dst, append ? FileWriteMode.Append : FileWriteMode.Overwrite);

        public static StreamWriter Writer(this FS.FilePath dst, FileWriteMode mode)
            => new StreamWriter(dst.CreateParentIfMissing().Name, mode == FileWriteMode.Append);

        /// <summary>
        /// Creates an overwriting and caller-disposed stream writer that targets a specified path
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter Writer(this FS.FilePath dst)
            => FS.writer(dst);

        public static FS.FilePath CreateParentIfMissing(this FS.FilePath src)
        {
            FileOps.CreateParent(src.Name.Format());
            return src;
        }

        public static void AppendLine(this FS.FilePath dst, string src)
            => File.AppendAllLines(dst.Name, z.array(src));

        public static FileStream Stream(this FS.FilePath path, FileMode mode = FileMode.OpenOrCreate, FileAccess access = FileAccess.Write, FileShare share = FileShare.Read)
            => FS.stream(path,mode,access,share);
    }
}