//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.IO;
    using System.Threading.Tasks;

    partial class XTend
    {
        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader Reader(this FilePath src)
            => FileSystem.reader(src);

        /// <summary>
        /// Creates a writer initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter Writer(this FilePath dst, bool append = false)
            => FileSystem.writer(dst,append);

        public static StreamWriter Writer(this FilePath dst, FileWriteMode mode)
            => FileSystem.writer(dst,mode);
    }
}