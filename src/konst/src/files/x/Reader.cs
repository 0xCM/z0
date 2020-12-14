//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    partial class XFs
    {
        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static string[] ReadLines(this FS.FilePath src)
            => FS.lines(src);

        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static StreamReader Reader(this FS.FilePath src)
            => FS.reader(src);
    }
}