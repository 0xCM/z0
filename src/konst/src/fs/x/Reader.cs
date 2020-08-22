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

        public static FS.FolderPath Normalize(this FS.FolderPath src)
            => new FS.FolderPath(src.Name.Replace(Chars.BSlash, Chars.FSlash));

    }
}