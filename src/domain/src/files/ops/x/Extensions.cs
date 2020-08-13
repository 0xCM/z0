//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XTend
    {
        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader Reader(this FS.FilePath src)
            => FS.reader(src);

        public static StreamWriter Writer(this FS.FilePath dst, FileWriteMode mode)
            => FS.writer(dst, mode);

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
    }
}