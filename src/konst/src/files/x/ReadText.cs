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
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static string ReadText(this FS.FilePath src)
            => FS.filetext(src);
    }
}