//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    partial class XFs
    {
        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static Index<string> ReadLines(this FS.FilePath src)
            => FS.lines(src);

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static TextLines ReadTextLines(this FS.FilePath src)
            => FS.text(src);
    }
}