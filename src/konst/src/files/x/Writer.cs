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
            => new StreamWriter(dst.EnsureParentExists().Name, mode == FileWriteMode.Append);

        /// <summary>
        /// Creates an overwriting and caller-disposed stream writer that targets a specified path
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter Writer(this FS.FilePath dst)
            => FS.writer(dst);

        /// <summary>
        /// Appends a line to a specified text file
        /// </summary>
        /// <param name="dst">The target file</param>
        /// <param name="src">The data to append</param>
        public static void AppendLine(this FS.FilePath dst, string src)
            => File.AppendAllLines(dst.EnsureParentExists().Name, root.array(src));

        /// <summary>
        /// Opens a <see cref='FileStream'/>
        /// </summary>
        /// <param name="path">The target file path</param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        public static FileStream Stream(this FS.FilePath path, FileMode mode = FileMode.OpenOrCreate, FileAccess access = FileAccess.ReadWrite, FileShare share = FileShare.Read)
            => FS.stream(path, mode, access, share);
    }
}