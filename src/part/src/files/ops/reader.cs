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

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static StreamReader reader(FS.FilePath src, Encoding encoding)
            => new StreamReader(src.Name.Format(), encoding);

        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        [MethodImpl(Inline), Op]
        public static StreamReader reader(FS.FilePath src)
            => reader(src, Encoding.UTF8);
    }
}